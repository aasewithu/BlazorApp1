using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public partial class About : ComponentBase
    {
        private string title = "정보";

        private string subTitle = "사이트 정보";

        protected override void OnInitialized()
        {
            subTitle = DateTime.Now.ToShortTimeString();
        }
    }
}
 