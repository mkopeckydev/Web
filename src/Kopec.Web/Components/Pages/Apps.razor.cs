using Kopec.Web.Data;
using Kopec.Web.Model;
using Microsoft.AspNetCore.Components;

namespace Kopec.Web.Components.Pages
{
    public partial class Apps : ComponentBase
    {
        IconListData listData = new();

        [Inject]
        private DataFacade DataFacade { get; set; } = default!;

        protected override async Task OnInitializedAsync()
        {
            listData = await DataFacade.AppsData();

            await base.OnInitializedAsync();
        }
    }
}
