using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototype.Models {
    public class Comentario {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDoComentario { get; set; }

    }
}