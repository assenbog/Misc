namespace MessageBroker.Subscriber.Test
{
    using System.Windows.Forms;
    using MessageBroker;

    /// <summary>
    /// The subscriber UI.
    /// </summary>
    public partial class SubscriberUi : Form
    {
        #region Private Variables

        /// <summary>
        /// The on subscriber message received callback.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private delegate void OnSubscriberMessageReceivedCallback(object sender, NotificationMessage e);

        #endregion Private Variables

        /// <summary>
        /// Initialises a new instance of the <see cref="SubscriberUi"/> class.
        /// </summary>
        public SubscriberUi()
        {
            InitializeComponent();

            var subscriber = new Subscriber();
            subscriber.MessageReceived += OnSubscriberMessageReceived;
        }

        /// <summary>
        /// The on subscriber message received.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnSubscriberMessageReceived(object sender, NotificationMessage e)
        {
            if (MessageTextBox.InvokeRequired)
            {
                var callBack = new OnSubscriberMessageReceivedCallback(OnSubscriberMessageReceived);
                Invoke(callBack, new[] { sender, e });
            }
            else
            {
                MessageTextBox.Text = e.Message;
            }
        }
    }
}
