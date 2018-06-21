namespace HomeOwnersAssociation.Shared
{
    using HomeOwnersAssociation.Shared.Members;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Committee" />
    /// </summary>
    public class Committee
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
        /// Gets or sets the members.
        /// </summary>
        /// <value>
        /// The members.
        /// </value>
        public List<Member> Members { get; set; } = new List<Member>();
    }
}
