using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    public class Donos
    {

        public Donos() 
        {//inicializar a lista de animais
            ListaDeAnimais = new HashSet<Animais>();
        }

        /// <summary>
        /// PK
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Numero de indentificação fiscal do dono
        /// </summary>
        public int NIF { get; set; }

        /// <summary>
        ///Lista dos animais que o Dono tem 
        /// </summary>
        
        public ICollection<Animais> ListaDeAnimais { get; set; }

    }
}
