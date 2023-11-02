﻿namespace Aplicacoes.Models
{
    public class InstituicaoModel
    {
        public long? InstituicaoId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<DepartamentoModel> Departamentos { get; set;}
    }
}
