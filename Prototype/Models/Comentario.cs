using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototype.Models {
    public class Comentario {
        /// TODO: Adicionar usuário aqui. Provavelmente após a inserção dos novos campos na tabela do usuário

        public int ID { get; set; }
        public int ReclamacaoID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDoComentario { get; set; }

        public virtual Reclamacao Reclamacao { get; set; }

    }
}