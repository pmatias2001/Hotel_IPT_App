using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_IPT.Models
{
    public class Utilizadores : IdentityUser
    {
        public Utilizadores()
        {
            // inicializar a lista de Reservas de cada um dos users
            ListaReservas = new HashSet<Reservas>();
        }

        /// <summary>
        /// Identificador de cada user
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do user
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        [Display(Name = "Data de nascimento")]
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "o {0} introduzido não é válido")]
        [RegularExpression("((((aluno)|(es((tt)|(ta)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt",
                           ErrorMessage = "Só são aceites emails do IPT.")]
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva um nº Telemóvel com 9 algarismos.")]
        [Display(Name = "Telemóvel")]
        public string Contacto { get; set; }

        /// <summary>
        /// NIF do utilizador
        /// </summary>
        public string NIF { get; set; }

        //************************************************************************************
        /// <summary>
        /// Funciona como Chave Forasteira no relacionamento entre os Criadores
        /// e a tabela de autenticação
        /// </summary>
        public string UserName { get; set; }

        // associar os users às suas reservas
        /// <summary>
        /// Lista das Reservas do user
        /// </summary>
        public ICollection<Reservas> ListaReservas { get; set; }


    }
}
