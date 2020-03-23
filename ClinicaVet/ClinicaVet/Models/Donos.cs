using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    public class Donos
    {
        /// <summary>
        /// PK
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Numero de indentificação fiscal do dono
        /// </summary>
        public int NIF { get; set; }


    }
}
