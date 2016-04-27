using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototype.Models {
    public class Usuario {
        public int ID { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public int Cep { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }
        public virtual ICollection<Reclamacao> Reclamacoes { get; set; }
        public virtual ICollection<Reclamacao> ReclamacoesSeguidas { get; set; }

    }
}