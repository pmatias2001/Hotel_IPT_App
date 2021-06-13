using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_IPT.Models
{
    public class Quartos
    {
        public Quartos()
        {
            // inicializar a lista de Fotos de cada um dos quartos
            ListaFotos = new HashSet<Fotos>();
            // inicializar a lista de Reservas de cada um dos quartos
            ListaReservas = new HashSet<Reservas>();
        }

        /// <summary>
        /// Identificador dos quartos
        /// </summary>
        [Key]
        public int IdQuarto { get; set; }

        /// <summary>
        /// Piso do quarto
        /// </summary>
        public int Piso { get; set; }

        /// <summary>
        /// Descrição do quarto
        /// </summary>
        [StringLength(100, MinimumLength = 10, ErrorMessage = "A {0} deve ter entre {2} e {1} caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        /// <summary>
        /// Número de pessoas por quarto
        /// </summary>
        [Display(Name = "Lotação")]
        public int Lotacao { get; set; }

        /// <summary>
        /// Preço associado ao quarto
        /// </summary>
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Preco { get; set; }

        /// <summary>
        /// Lista das Fotografias do quarto
        /// </summary>
        public ICollection<Fotos> ListaFotos { get; set; }

        // associar os quartos às suas reservas
        /// <summary>
        /// Lista das Reservas do Quarto
        /// </summary>
        public ICollection<Reservas> ListaReservas { get; set; }
    }
}
