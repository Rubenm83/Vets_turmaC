using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVet.Models
{
    public class Veterinarios
    {
        public Veterinarios() 
        {
            Consultas = new HashSet<Consultas>();
        }

        public int ID { get; set; }

        public string Nome { get; set; }

        public string NumCedulaProf { get; set; }

        public int Fotografia { get; set; }

        //Lista de 'consultas' a que o Veterinário está associado

        public ICollection<Consultas> Consultas { get; set; }


    }
}
