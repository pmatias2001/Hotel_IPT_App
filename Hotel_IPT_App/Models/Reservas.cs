using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_IPT.Models
{
    public class Reservas
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
        /// Estado da reserva; true se está ativa (foi paga e estamos entre a data inicial e final) 
        /// false se não está ativa (já passou o prazo, não foi paga ou foi cancelada)
        /// </summary>
        public Boolean Estado { get; set; }

        // criação da FK que referencia o User a que a Reserva pertence
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
    }
}
