namespace HomeOwnersAssociation.Shared.Members
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Ownership" />
    /// </summary>
    public class Ownership
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the purchase date.
        /// </summary>
        /// <value>
        /// The purchase date.
        /// </value>
        public DateTimeOffset PurchaseDate { get; set; }

        /// <summary>
        /// Gets or sets the sold date.
        /// </summary>
        /// <value>
        /// The sold date.
        /// </value>
        public DateTimeOffset? SoldDate { get; set; }

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>
        /// The members.
        /// </value>
        public List<Member> Members { get; set; } = new List<Member>();
    }
}
