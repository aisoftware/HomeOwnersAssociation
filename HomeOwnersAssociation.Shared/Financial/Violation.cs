namespace HomeOwnersAssociation.Shared.Financial
{
    using HomeOwnersAssociation.Shared.Legal;
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
        /// Gets or sets the article.
        /// </summary>
        /// <value>
        /// The article.
        /// </value>
        public Article Article { get; set; }
    }
}
