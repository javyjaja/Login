using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class userViewModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public string Estatus { get; set; }
        public bool EstatusBool { get; set; }

        public string password { get; set; }
    }
}