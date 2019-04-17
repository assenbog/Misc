namespace MessageBroker.Publisher.Test
{
    using System;
    using System.Windows.Forms;
    using MessageBroker;

    /// <summary>
    /// The publisher UI.
    /// </summary>
    public partial class PublisherUi : Form
    {
        #region Private Variables

        private readonly Publisher publisher;

        #endregion Private Variables

        /// <summary>
        /// Initialises a new instance of the <see cref="PublisherUi"/> class.
        /// </summary>
        public PublisherUi()
        {
            InitializeComponent();

            publisher = new Publisher();

            publisher.MessageDeliveredEvent += OnPublisherMessageDelivered;
            publisher.MessageNotDeliveredEvent += OnPublisherMessageNotDelivered;
        }

        /// <summary>
        /// The on publisher message delivered.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnPublisherMessageDelivered(object sender, EventArgs e)
        {
            MessageBox.Show("Message delivered!");
        }

        /// <summary>
        /// The on publisher message delivered.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void OnPublisherMessageNotDelivered(object sender, EventArgs e)
        {
            MessageBox.Show("Message NOT delivered!");
        }

        /// <summary>
        /// The on publish message button click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OnPublishMessageButtonClick(object sender, EventArgs e)
        {
            try
            {
                publisher.SendMessage(EventIdEnum.XmlMessage, MessageTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Message could not be sent!\n\n{0}", ex.Message), "Send Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
