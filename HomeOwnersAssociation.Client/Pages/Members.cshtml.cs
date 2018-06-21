using BlazorState;
using HomeOwnersAssociation.Client.Features.Members;
using HomeOwnersAssociation.Shared.Members;
using MediatR;
using Microsoft.AspNetCore.Blazor.Components;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace HomeOwnersAssociation.Client.Pages
{
    public class MembersModel : BlazorComponent, IBlazorStateComponent
    {
        public MemberState MemberState => Store.GetState<MemberState>();
        [Inject] public IMediator Mediator { get; set; }
        [Inject] public IStore Store { get; set; }
        [Inject] public HttpClient Http { get; set; }


        protected override async Task OnInitAsync()
        {
            if (MemberState.Members == null)
            {
                MemberState.Members = await Http.GetJsonAsync<Member[]>("api/Member/List");
            }
        }
    }
}
