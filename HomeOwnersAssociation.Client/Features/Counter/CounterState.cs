using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorState;

namespace HomeOwnersAssociation.Client.Features.Counter
{
    public class CounterState : State<CounterState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CounterState" /> class.
        /// </summary>
        public CounterState() { } // needed for serialization

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterState" /> class.
        /// </summary>
        /// <param name="aState">a state.</param>
        protected CounterState(CounterState aState) : this()
        {
            Count = aState.Count;
        }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override object Clone() => new CounterState(this);

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        protected override void Initialize()
        {
            Count = 3;
        }
    }
}
