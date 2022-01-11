using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Diagnostics;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int i = 0;
            while (true)
            {
                if (i > 1000)
                {
                    --i;
                }
                else
                {
                    ++i;
                }
                if (watch.ElapsedMilliseconds > 10000)
                    break;
            }
            _logger.LogInformation("");
        }
    }
}