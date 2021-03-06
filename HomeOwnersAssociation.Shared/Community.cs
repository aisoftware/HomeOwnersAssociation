﻿namespace HomeOwnersAssociation.Shared
{
    using HomeOwnersAssociation.Shared.Meeting;
    using HomeOwnersAssociation.Shared.Members;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Community" />
    /// </summary>
    public class Community
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
        /// Gets or sets the residences.
        /// </summary>
        /// <value>
        /// The residences.
        /// </value>
        public List<Residence> Residences { get; set; }

        /// <summary>
        /// Gets or sets the established.
        /// </summary>
        /// <value>
        /// The established.
        /// </value>
        public DateTimeOffset Established { get; set; } = DateTime.Now.Date;

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        /// <value>
        /// The members.
        /// </value>
        public List<Member> Members { get; set; } = new List<Member>();

        /// <summary>
        /// Gets or sets the boards.
        /// </summary>
        /// <value>
        /// The boards.
        /// </value>
        public List<Year> Boards { get; set; } = new List<Year>();

        /// <summary>
        /// Gets or sets the committees.
        /// </summary>
        /// <value>
        /// The committees.
        /// </value>
        public List<Committee> Committees { get; set; } = new List<Committee>();

        /// <summary>
        /// Gets or sets the articles.
        /// </summary>
        /// <value>
        /// The articles.
        /// </value>
        public List<Legal.Article> ArticlesOfIncorporation { get; set; } = new List<Legal.Article>();

        /// <summary>
        /// Gets or sets the news.
        /// </summary>
        /// <value>
        /// The news.
        /// </value>
        public List<News.Article> News { get; set; } = new List<News.Article>();

    }
}
