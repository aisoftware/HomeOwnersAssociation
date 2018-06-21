namespace HomeOwnersAssociation.Shared.Members
{
    using HomeOwnersAssociation.Shared.Financial;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Residence" />
    /// </summary>
    public class Residence
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the lot.
        /// </summary>
        /// <value>
        /// The lot.
        /// </value>
        public string Lot { get; set; }

        /// <summary>
        /// Gets or sets the ownership history.
        /// </summary>
        /// <value>
        /// The ownership history.
        /// </value>
        public List<Ownership> OwnershipHistory { get; set; } = new List<Ownership>();

        /// <summary>
        /// Gets or sets the fines.
        /// </summary>
        /// <value>
        /// The fines.
        /// </value>
        public List<Fine> Fines { get; set; } = new List<Fine>();

        /// <summary>
        /// Gets or sets the dues.
        /// </summary>
        /// <value>
        /// The dues.
        /// </value>
        public List<Dues> Dues { get; set; } = new List<Dues>();
    }
}
