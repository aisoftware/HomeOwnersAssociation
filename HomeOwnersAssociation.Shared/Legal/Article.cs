namespace HomeOwnersAssociation.Shared.Legal
{
    using HomeOwnersAssociation.Shared.Meeting;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Shared.Article" />
    /// </summary>
    public class Article
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        /// <value>
        /// The section.
        /// </value>
        public string Section { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the approved on.
        /// </summary>
        /// <value>
        /// The approved on.
        /// </value>
        public DateTimeOffset? ApprovedOn { get; set; }

        /// <summary>
        /// Gets or sets the votes.
        /// </summary>
        /// <value>
        /// The votes.
        /// </value>
        public List<AmendmentVote> Votes { get; set; } = new List<AmendmentVote>();
    }
}
