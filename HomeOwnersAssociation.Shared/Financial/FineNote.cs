namespace HomeOwnersAssociation.Shared.Financial
{
    using System;

    /// <summary>
    /// Defines the <see cref="FineNote" />
    /// </summary>
    public class FineNote
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the occurred on.
        /// </summary>
        /// <value>
        /// The occurred on.
        /// </value>
        public DateTimeOffset OccurredOn { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }
    }
}
