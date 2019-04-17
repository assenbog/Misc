namespace MessageBroker
{
    using System;

    /// <summary>
    /// The message broker event args.
    /// </summary>
    public class NotificationMessage : EventArgs
    {
        /// <summary>
        /// Gets or sets the event id.
        /// </summary>
        public EventIdEnum EventId { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }
    }
}
