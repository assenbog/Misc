using System;
using System.Threading;
using System.Threading.Tasks;
using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.NamedPipeMessagingSystem;

namespace MessageBroker
{

    /// <summary>
    /// The publisher.
    /// </summary>
    public class Publisher : IDisposable
    {
        #region Private Variables

        private IReliableTypedMessageSender<bool?, NotificationMessage> _messageSender;

        private IDuplexOutputChannel _channel;

        #endregion Private Variables

        #region Constructor

        /// <summary>
        /// Initialises a new instance of the <see cref="Publisher"/> class.
        /// </summary>
        public Publisher()
        {
            ConfigureReceiver();

            Task configureBrokerTask = CreateTaskWithRetry(AttachDuplexChannel, 0, 500);

            configureBrokerTask.Start();
        }

        #endregion Overrides

        #region Public Events

        /// <summary>
        /// The message delivered event.
        /// </summary>
        public event EventHandler MessageDeliveredEvent;

        /// <summary>
        /// The message not delivered event.
        /// </summary>
        public event EventHandler MessageNotDeliveredEvent;

        /// <summary>
        /// The connection closed event.
        /// </summary>
        public event EventHandler ConnectionClosedEvent;

        #endregion Public Events

        #region Public Methods
        
        /// <summary>
        /// The send message.
        /// </summary>
        /// <param name="eventId">The event id.</param>
        /// <param name="serialisedMessage">The serialised message.</param>
        public void SendMessage(EventIdEnum eventId, string serialisedMessage)
        {
            var notificationMessage = new NotificationMessage
                                      {
                                          EventId = EventIdEnum.XmlMessage,

                                          // Need to wrap up the message in a string element
                                          Message = string.Format(@"<string>{0}</string>", serialisedMessage)
                                      };

            _messageSender.SendRequestMessage(notificationMessage);
        }

        #endregion Public Methods

        #region IDisposable Implementation

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            if (_messageSender != null)
            {
                _messageSender.DetachDuplexOutputChannel();
            }
        }
        
        #endregion IDisposable Implementations

        #region Private Methods

        /// <summary>
        /// The create task with retry.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="retryCount">The retry count.</param>
        /// <param name="millisecondWaitBetweenRetries">The millisecond wait between retries.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        private static Task CreateTaskWithRetry(Action action, int retryCount, int millisecondWaitBetweenRetries = 0)
        {
            Action retryAction = () =>
            {
                int attemptNumber = 0;
                var success = false;
                do
                {
                    try
                    {
                        if (retryCount > 0)
                        {
                            attemptNumber++;
                        }

                        action();
                        success = true;
                    }
                    catch (Exception exception) // use your the exception that you need
                    {
                        // ToDo: log error
                        if (retryCount > 0 && attemptNumber == retryCount)
                        {
                            throw;
                        }
                    }
                    if (millisecondWaitBetweenRetries > 0)
                    {
                        Thread.Sleep(millisecondWaitBetweenRetries);
                    }
                }
                while (!success || (retryCount > 0 && attemptNumber < retryCount));
            };

            return new Task(retryAction);
        }

        /// <summary>
        /// The configure receiver.
        /// </summary>
        private void ConfigureReceiver()
        {
            // Create reliable message receiver.
            var messagesFactory = new ReliableTypedMessagesFactory();

            _messageSender = messagesFactory.CreateReliableDuplexTypedMessageSender<bool?, NotificationMessage>();

            _messageSender.MessageDelivered += OnMessageDelivered;
            _messageSender.MessageNotDelivered += OnMessageNotDelivered;
            _messageSender.ConnectionClosed += OnConnectionClosed;

            // Create Named Pipe based messaging to communicate with clients.
            IMessagingSystemFactory messageFactory = new NamedPipeMessagingSystemFactory();

            _channel = messageFactory.CreateDuplexOutputChannel(Constants.ChannelId);
        }

        /// <summary>
        /// The on receiver response message delivered.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnMessageDelivered(object sender, ReliableMessageIdEventArgs e)
        {
            if (MessageDeliveredEvent != null)
            {
                MessageDeliveredEvent(this, new EventArgs());
            }
        }

        /// <summary>
        /// The on receiver response message not delivered.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnMessageNotDelivered(object sender, ReliableMessageIdEventArgs e)
        {
            if (MessageNotDeliveredEvent != null)
            {
                MessageNotDeliveredEvent(this, new EventArgs());
            }
        }

        /// <summary>
        /// The on connection closed handler.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnConnectionClosed(object sender, DuplexChannelEventArgs e)
        {
            if (ConnectionClosedEvent != null)
            {
                ConnectionClosedEvent(this, new EventArgs());
            }
        }

        /// <summary>
        /// The attach duplex channel.
        /// </summary>
        private void AttachDuplexChannel()
        {
            // Attach output channel and start listening.
            _messageSender.AttachDuplexOutputChannel(_channel);
        }

        #endregion Private Methods
    }
}
