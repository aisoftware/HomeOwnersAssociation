using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeOwnersAssociation.Client.Features.Counter.IncrementCount
{
    public class IncrementCountRequest : IRequest<CounterState>
    {
        public int Amount { get; set; }
    }
}
