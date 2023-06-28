using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaMvc.Models.Enuns;



namespace AgendaMvc.Models
{
    public class AulaViewModel
    {
         public int Id { get; set; }
        public string Nome { get; set; }
        public string Professor { get; set; }
        public int Quantidade {get; set;}
        public ClasseEnum Classe { get; set; }
    }
}