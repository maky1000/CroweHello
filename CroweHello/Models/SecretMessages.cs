using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CroweHello.Models
{
    //Model object 
    public class SecretMessages
    {
        [Required]
        public string Data { get; set; }
    }
}