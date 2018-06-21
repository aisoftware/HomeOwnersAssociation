using HomeOwnersAssociation.Shared.Members;
using System;

namespace HomeOwnersAssociation.Shared.Meeting
{
    public class BallotVote
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the member.
        /// </summary>
        /// <value>
        /// The member.
        /// </value>
        public Member Member { get; set; }

        /// <summary>
        /// Gets or sets the candidate.
        /// </summary>
        /// <value>
        /// The candidate.
        /// </value>
        public Member Candidate { get; set; }
    }
}