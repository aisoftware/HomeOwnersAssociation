using HomeOwnersAssociation.Shared.Members;
using System;

namespace HomeOwnersAssociation.Shared.Meeting
{
    public class AmendmentVote
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
        /// Gets or sets the voted on.
        /// </summary>
        /// <value>
        /// The voted on.
        /// </value>
        public DateTimeOffset VotedOn { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AmendmentVote"/> is approved.
        /// </summary>
        /// <value>
        ///   <c>true</c> if approved; otherwise, <c>false</c>.
        /// </value>
        public bool Approved { get; set; }
    }
}