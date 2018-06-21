using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorState;
using HomeOwnersAssociation.Shared.Members;

namespace HomeOwnersAssociation.Client.Features.Members
{
    public class MemberState : State<MemberState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberState" /> class.
        /// </summary>
        public MemberState() { } // needed for serialization

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberState" /> class.
        /// </summary>
        /// <param name="aState">a state.</param>
        protected MemberState(MemberState aState) : this()
        {
            Members = aState.Members;
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public Member[] Members { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override object Clone() => new MemberState(this);

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected override void Initialize()
        {
            Members = null;
        }
    }
}
