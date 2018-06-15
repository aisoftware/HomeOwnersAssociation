namespace HomeOwnersAssociation.Shared
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Member" />
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone numbers.
        /// </summary>
        /// <value>
        /// The phone numbers.
        /// </value>
        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [privacy enabled].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [privacy enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool PrivacyEnabled { get; set; }
    }
}
