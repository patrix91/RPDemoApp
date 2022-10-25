using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RPDemo.Pages
{
    public class MyForm : PageModel
    {
        private readonly ILogger<MyForm> _logger;

        public MyForm(ILogger<MyForm> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}