using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogViewComponent.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogViewComponent.ViewComponents
{
    public class QuickExample5ViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string randomText)
        {
            return View(new QuickExampleModel { Text = randomText });
        }
    }
}
