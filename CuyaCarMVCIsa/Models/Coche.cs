using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CuyaCarMVCIsa.Models
{
    public class Coche
    {
        //private int _bastidor;

        //[Key]
        public int Bastidor { get; set; }
        public string Marca { get; set; }
        public string Matricula { get; set; }
    }
}