using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CuyaCarMVCIsa.Models
{
    public class Coche
    {
        [Key] 
        public int bastidor { get; set; }
        public string marca { get; set; }
        public string matricula { get; set; }

    }
}