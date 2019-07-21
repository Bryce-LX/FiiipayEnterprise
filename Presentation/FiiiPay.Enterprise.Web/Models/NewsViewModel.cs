using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiiiPay.Enterprise.Web.Models
{
    public class NewsViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public byte Status { get; set; }
    }
}