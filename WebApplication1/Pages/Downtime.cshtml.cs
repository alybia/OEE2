using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Pages
{
    public class DowntimeModel : PageModel
    { 
        private readonly ILogger<DowntimeModel> _logger;

        public DowntimeModel(ILogger<DowntimeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
