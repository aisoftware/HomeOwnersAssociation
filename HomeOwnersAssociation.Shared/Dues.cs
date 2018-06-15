namespace HomeOwnersAssociation.Shared
{
    using System;

    /// <summary>
    /// Defines the <see cref="Dues" /></summary>
    public class Dues
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the issued.
        /// </summary>
        /// <value>
        /// The issued.
        /// </value>
        public DateTimeOffset Issued { get; set; }

        /// <summary>
        /// Gets or sets the paid.
        /// </summary>
        /// <value>
        /// The paid.
        /// </value>
        public DateTimeOffset? Paid { get; set; }
    }
}
