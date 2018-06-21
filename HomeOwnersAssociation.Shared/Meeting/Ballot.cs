namespace HomeOwnersAssociation.Shared.Meeting
{
    using HomeOwnersAssociation.Shared.Members;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Ballot" />
    /// </summary>
    public class Ballot
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the election date.
        /// </summary>
        /// <value>
        /// The election date.
        /// </value>
        public DateTimeOffset ElectionDate { get; set; }

        /// <summary>
        /// Gets or sets the candidates.
        /// </summary>
        /// <value>
        /// The candidates.
        /// </value>
        public List<Member> Candidates { get; set; } = new List<Member>();

        /// <summary>
        /// Gets or sets the votes.
        /// </summary>
        /// <value>
        /// The votes.
        /// </value>
        public List<BallotVote> Votes { get; set; } = new List<BallotVote>();

    }
}
