using System.Threading;
using System.Threading.Tasks;
using BlazorState;

namespace HomeOwnersAssociation.Client.Features.Counter.IncrementCount
{
    public class IncrementCountHandler : RequestHandler<IncrementCountRequest, CounterState>
    {
        public IncrementCountHandler(IStore aStore) : base(aStore) { }

        public CounterState CounterState => Store.GetState<CounterState>();

        public override Task<CounterState> Handle(IncrementCountRequest request, CancellationToken cancellationToken)
        {
            CounterState.Count += request.Amount;
            return Task.FromResult(CounterState);
        }
    }
}
