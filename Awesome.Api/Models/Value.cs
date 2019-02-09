using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Awesome.Api.Models
{
    public class Value
    {

        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}