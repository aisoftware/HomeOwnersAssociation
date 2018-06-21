using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorState;
using HomeOwnersAssociation.Shared.Members;

namespace HomeOwnersAssociation.Client.Features.Members
{
    public class ResidenceState : State<ResidenceState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResidenceState" /> class.
        /// </summary>
        public ResidenceState() { } // needed for serialization

        /// <summary>
        /// Initializes a new instance of the <see cref="ResidenceState" /> class.
        /// </summary>
        /// <param name="aState">a state.</param>
        protected ResidenceState(ResidenceState aState) : this()
        {
            Residences = aState.Residences;
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public Residence[] Residences { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override object Clone() => new ResidenceState(this);

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected override void Initialize()
        {
            Residences = null;
        }
    }
}
