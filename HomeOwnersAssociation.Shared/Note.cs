namespace HomeOwnersAssociation.Shared
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Note" />
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the note date.
        /// </summary>
        /// <value>
        /// The note date.
        /// </value>
        public DateTimeOffset NoteDate { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        public List<Tag<Note>> Tags { get; set; }
    }
}
