namespace HomeOwnersAssociation.Shared
{
    using System;

    /// <summary>
    /// Defines the <see cref="Violation" />
    /// </summary>
    public class Violation
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the restriction.
        /// </summary>
        /// <value>
        /// The restriction.
        /// </value>
        public Restriction Restriction { get; set; }
    }
}
