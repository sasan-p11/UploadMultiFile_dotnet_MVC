using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UploadFileMvc.Views.Upload;

public class MultiFile : PageModel
{
    private readonly ILogger<MultiFile> _logger;

    public MultiFile(ILogger<MultiFile> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

