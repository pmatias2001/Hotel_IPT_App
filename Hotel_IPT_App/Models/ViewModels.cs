using System;
using System.Collections.Generic;

namespace Hotel_IPT_App.Models
{
    /// <summary>
    /// lista os dados dos quartos a serem disponibilizados na API
    /// </summary>
    public class QuartosAPIViewModel
    {
        /// <summary>
        /// identificador do Quarto
        /// </summary>
        public int IdQuarto { get; set; }

        /// <summary>
        /// Nome do Quarto
        /// </summary>
        public string NomeQuarto { get; set; }
    }



    /// <summary>
    /// ViewModel para transportar os dados das Fotografias
    /// dos quartos, na API
    /// </summary>
    public class FotosAPIViewModel
    {
        /// <summary>
        /// id da Foto
        /// </summary>
        public int IdFoto { get; set; }

        /// <summary>
        /// nome do ficheiro da foto
        /// </summary>
        public string NomeFoto { get; set; }

        /// <summary>
        /// data em que a foto foi tirada
        /// </summary>
        public string DataFoto { get; set; }

        /// <summary>
        /// nome do Quarto
        /// </summary>
        public string NomeQuarto { get; set; }
    }




    /// <summary>
    /// classe para permitir o transporte do Controller para a View, e vice-versa
    /// irá transportar os dados das Fotografias e dos IDs do Quartos que pertencem 
    /// à pessoa autenticada
    /// </summary>
    public class FotosCaes
    {

        /// <summary>
        /// lista de todas as fotografias de todos os cães
        /// </summary>
        public ICollection<Fotos> ListaFotos { get; set; }

        /// <summary>
        /// lista dos IDs dos cães que pertencem à pessoa autenticada
        /// </summary>
        public ICollection<int> ListaQuartos { get; set; }

    }




    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
