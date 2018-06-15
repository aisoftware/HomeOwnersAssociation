namespace HomeOwnersAssociation.Shared
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Fine" />
    /// </summary>
    public class Fine
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public Tag<Fine> Tag { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public List<FineNote> Notes { get; set; } = new List<FineNote>();

        /// <summary>
        /// Gets or sets the paid.
        /// </summary>
        /// <value>
        /// The paid.
        /// </value>
        public DateTimeOffset? Paid { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the violations.
        /// </summary>
        /// <value>
        /// The violations.
        /// </value>
        public List<Violation> Violations { get; set; } = new List<Violation>();
    }
}
