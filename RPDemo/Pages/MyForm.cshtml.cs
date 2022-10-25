using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using RPDemo.Model;

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

        [HttpPost("save")]
        public ActionResult OnPost()
        {
            var mail = Request.Form["email"];
            var pass = Request.Form["password"];
            UserEmail um = new();
            um.Email = mail;
            um.Password = pass;

            if (um is null)
            {
                return NotFound();
            }

            try
            {
                bool isExist;
                if (System.IO.File.Exists(@"c:\file.txt"))
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }


                StreamWriter sw = new StreamWriter(@"c:\file.txt", isExist);
                sw.WriteLine(um.Email + " " + um.Password);

                sw.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }

            return Page();
        }
    }
}