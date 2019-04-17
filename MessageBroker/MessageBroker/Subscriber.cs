using System;
using System.Xml.Linq;
using Eneter.Messaging.EndPoints.TypedMessages;
using Eneter.Messaging.MessagingSystems.MessagingSystemBase;
using Eneter.Messaging.MessagingSystems.NamedPipeMessagingSystem;

namespace MessageBroker
{

    /// <summary>
    /// The subscriber.
    /// </summary>
    public class Subscriber : IDisposable
    {
        #region Private Variables

        private IReliableTypedMessageReceiver<bool?, NotificationMessage> _receiver;

        #endregion Private Variables

        #region Constructor

        /// <summary>
        /// Initialises a new instance of the <see cref="Subscriber"/> class.
        /// </summary>
        public Subscriber()
        {
            ConfigureReceiver();
        }

        #endregion Overrides

        #region Public Events

        /// <summary>
        /// The message received.
        /// </summary>
        public event EventHandler<NotificationMessage> MessageReceived;

        #endregion Public Events

        #region IDisposable Implementation

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            if (_receiver != null)
            {
                _receiver.DetachDuplexInputChannel();
            }
        }

        #endregion IDisposable Implementation

        #region Private Methods

        /// <summary>
        /// The configure broker client.
        /// </summary>
        private void ConfigureReceiver()
        {
            // Create reliable message receiver.
            var receiverFactory = new ReliableTypedMessagesFactory();

            _receiver = receiverFactory.CreateReliableDuplexTypedMessageReceiver<bool?, NotificationMessage>();

            // Create the Shared Memory messaging for the communication with the publisher.
            // Note: For the interprocess communication you can use: Tcp, NamedPipes and Http.
            IMessagingSystemFactory factory = new NamedPipeMessagingSystemFactory();

            // Create duplex output channel for the communication with the publisher.
            // Note: The duplex output channel can send requests and receive responses.
            //       In our case, the broker client will send requests to subscribe/unsubscribe
            //       and receive notifications as response messages.
            var channel = factory.CreateDuplexInputChannel(Constants.ChannelId);

            _receiver.MessageReceived += OnMessageReceived;

            // Attach the output channel to the broker client
            _receiver.AttachDuplexInputChannel(channel);
        }

        /// <summary>
        /// The on message received.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnMessageReceived(object sender, TypedRequestReceivedEventArgs<NotificationMessage> e)
        {
            // Message is wrapped in <string> tags, so we need to strip them
            var message = XDocument.Parse(e.RequestMessage.Message);

            if (MessageReceived != null && message.Root != null)
            {

                MessageReceived(this, new NotificationMessage { EventId = e.RequestMessage.EventId, Message = message.Root.Value });
            }
        }

        #endregion Private Methods
    }
}
