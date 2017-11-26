using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projetoProfessor
{
    public class Professor
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

        public Professor()
        {
        }

        public Professor(string nome, string email, string senha, string telefone, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Ativo = ativo;
        }
    }
}