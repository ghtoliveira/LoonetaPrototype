using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototype.Models {
    public class Reclamacao {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDoAContecimento { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
        public int VotosPositivos { get; set; }
        public int VotosNegativos { get; set; }


        public virtual ICollection<TagReclamacao> Tags { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }




    }
}