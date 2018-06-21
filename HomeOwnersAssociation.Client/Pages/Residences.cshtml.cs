using BlazorState;
using MediatR;
using Microsoft.AspNetCore.Blazor.Components;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using HomeOwnersAssociation.Shared.Members;
using HomeOwnersAssociation.Client.Features.Members;

namespace HomeOwnersAssociation.Client.Pages
{
    public class ResidencesModel : BlazorComponent, IBlazorStateComponent
    {
        public ResidenceState ResidenceState => Store.GetState<ResidenceState>();
        [Inject] public IMediator Mediator { get; set; }
        [Inject] public IStore Store { get; set; }
        [Inject] public HttpClient Http { get; set; }


        protected override async Task OnInitAsync()
        {
            if (ResidenceState.Residences == null)
            {
                ResidenceState.Residences = await Http.GetJsonAsync<Residence[]>("api/Residence/List");
            }
        }
    }
}
