using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    /// <summary>
    /// Classe representa a tabela dos 'Animais' na base de dados
    /// </summary>
    public class Animais
    {

        public Animais() {
            ListaConsultas = new HashSet<Consultas>();
        }
        /// <summary>
        /// PK da tabele
        /// </summary>
        [Key]
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

        /// <summary>
        /// FK para a tabela dos Donos
        /// </summary>
        [ForeignKey(nameof(Dono))]  //Animais ---> Dono
        public int DonoFK { get; set; }
        public virtual Donos Dono { get; set; }

        /// <summary>
        /// Lista de Consultas a que o animal foi levado pelo seu dono
        /// </summary>
        public virtual ICollection<Consultas> ListaConsultas { get; set; }
    }
}
