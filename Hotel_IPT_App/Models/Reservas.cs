using CustomDataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_IPT_App.Models
{
    public class Reservas : IValidatableObject
    {
        public Reservas()
        {
            // inicializar a lista de Quartos de cada uma das reservas
            ListaQuartos = new HashSet<Quartos>();
        }
        /// <summary>
        /// Identificador das reservas
        /// </summary>
        [Key]
        public int IdReserva { get; set; }

        /// <summary>
        /// Data inicial da reserva
        /// </summary>
        [Display(Name = "Data inicial")]
        [CurrentDate(ErrorMessage = "{0} tem de ser maior que a data atual")]
        public DateTime DataInicial { get; set; }

        /// <summary>
        /// Data final da reserva
        /// </summary>
        [Display(Name = "Data final")]
        public DateTime DataFim { get; set; }

        /// <summary>
        /// Número de pessoas por reserva
        /// </summary>
        [Display(Name = "Número de pessoas")]
        public int NPessoas { get; set; }

        /// <summary>
        ///criação da FK que referencia o User a que a Reserva pertence
        /// </summary>
        [ForeignKey(nameof(Cliente))]
        [Display(Name = "Utilizador")]
        public int UserFK { get; set; }
        public Utilizadores Cliente { get; set; }

        //lista de quartos
        // associar as reservas aos seus quartos
        /// <summary>
        /// Lista das Reservas do Quarto
        /// </summary>
        public ICollection<Quartos> ListaQuartos { get; set; }

        //verifica se a data final é maior que a data inicial, se não for não aceita a validação
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (DataFim < DataInicial)
            {
                yield return new ValidationResult("Data final tem de ser maior que a data inicial");
            }
        }
    }
}
