namespace HomeOwnersAssociation.Shared
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Year" />
    /// </summary>
    public class Year
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the ballot.
        /// </summary>
        /// <value>
        /// The ballot.
        /// </value>
        public Ballot Ballot { get; set; }

        /// <summary>
        /// Gets or sets the board members.
        /// </summary>
        /// <value>
        /// The board members.
        /// </value>
        public List<Member> BoardMembers { get; set; } = new List<Member>();

        /// <summary>
        /// Gets or sets the minutes.
        /// </summary>
        /// <value>
        /// The minutes.
        /// </value>
        public List<Minutes> Minutes { get; set; } = new List<Minutes>();
    }
}
