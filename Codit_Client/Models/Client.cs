using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codit_Client.Models
{
    public class Client
    {
        [Required]
        public string fullName { get; set; } = string.Empty;

        [Required]
        public string email { get; set; } = string.Empty;

        [Required]
        public string phone { get; set; } = string.Empty;
    }
}