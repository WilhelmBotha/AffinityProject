using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AffinityProject.ViewModels
{
    public class CsvUploadViewModel
    {
        [Required]
        public IFormFile FormFile { get; set; }
    }
}
