using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Pages
{
    public class ScrapModel : PageModel
    {
        private readonly ILogger<ScrapModel> _logger;

        public ScrapModel(ILogger<ScrapModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
