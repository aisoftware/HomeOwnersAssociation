namespace HomeOwnersAssociation.Shared
{
    using System;

    /// <summary>
    /// Defines the <see cref="Tag{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Tag<T>
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
    }
}
