using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength(40,ErrorMessage="O {0} só pode ter , no máximo,{1} caracteres.")]
        public string Nome { get; set; }
        [Required]
        public string NumCedulaProf { get; set; }

        public int Fotografia { get; set; }

        //Lista de 'consultas' a que o Veterinário está associado

        public ICollection<Consultas> Consultas { get; set; }


    }
}
