using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_IPT.Models
{
    public class Fotos
    {

        /// <summary>
        /// Identificador das fotos
        /// </summary>
        [Key]
        public int IdFoto { get; set; }

        /// <summary>
        /// Nome do ficheiro da foto
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// Data da foto
        /// </summary>
        [Display(Name = "Data da fotografia")]
        public DateTime Data { get; set; }

        //****************************************

        // criação da FK que referencia o Quarto a que a Foto pertence
        [ForeignKey(nameof(Quarto))]
        [Display(Name = "Quarto")]
        public int QuartoFK { get; set; }
        public Quartos Quarto { get; set; }
    }
}
