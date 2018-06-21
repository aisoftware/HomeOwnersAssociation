using BlazorState;
using HomeOwnersAssociation.Client.Features.Counter;
using HomeOwnersAssociation.Client.Features.Counter.IncrementCount;
using MediatR;
using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeOwnersAssociation.Client.Pages
{
    public class CounterModel : BlazorComponent, IBlazorStateComponent
    {
        public CounterState CounterState => Store.GetState<CounterState>();
        [Inject] public IMediator Mediator { get; set; }
        [Inject] public IStore Store { get; set; }

        public void IncrementCount()
        {
            var incrementCountRequest = new IncrementCountRequest { Amount = 3 };
            Mediator.Send(incrementCountRequest);
        }
    }
}
