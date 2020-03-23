using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela dos 'Animais' na base de dados
    /// </summary>
    public class Animais
    {
        /// <summary>
        /// PK da tabele
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Nome do Animal
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Espécie do Animal
        /// </summary>
        public string Especie { get; set; }

        /// <summary>
        /// Peso do Animal
        /// </summary>
        public float Peso { get; set; }

        /// <summary>
        /// Raça do Animal
        /// </summary>
        public string Raca { get; set; }

        /// <summary>
        /// Nome do Ficheiro com a fotografia do Animal
        /// </summary>
        public string Foto { get; set; }

    }
}
