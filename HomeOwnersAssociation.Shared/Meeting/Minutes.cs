namespace HomeOwnersAssociation.Shared.Meeting
{
    using HomeOwnersAssociation.Shared.Members;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Minutes" />
    /// </summary>
    public class Minutes
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the meeting date.
        /// </summary>
        /// <value>
        /// The meeting date.
        /// </value>
        public DateTimeOffset MeetingDate { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Gets or sets the attendees.
        /// </summary>
        /// <value>
        /// The attendees.
        /// </value>
        public List<Member> Attendees { get; set; }

        /// <summary>
        /// Gets or sets the note taker.
        /// </summary>
        /// <value>
        /// The note taker.
        /// </value>
        public Member NoteTaker { get; set; }
    }
}
