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
        /*[RegularExpression("[A-ZÁÍÓUÉÁ][a-zãõáéíóúàèìòùçâêîôû]" +
            "[A-Z][a-z]+(( | e |-|'|d'| de | d[ao]s?)[A-Z][a-z]+){1,3}", ErrorMessage = "Só são aceites letras.Cada palavra deve começar por uma Maiscula")]*/
        public string Nome { get; set; }

        
        // Vet-XXX XXX ----> a palavra VET , um hífen , seguido de 6 digitos
        [Required]
        [RegularExpression("vet-[0-9]{6}",ErrorMessage ="Deve introduzir a palavra 'vet-'(em minúsculas),seguida de 6 dígitos.")]
        [StringLength(10, ErrorMessage = "O {0} só pode ter , no máximo,{1} caracteres.")]
        [Display(Name = "Nº de Cédula Profisional")]
        public string NumCedulaProf { get; set; }

        public string Foto { get; set; }

        /// <summary>
        /// Lista de 'consultas' a que o Veterinário está associado
        /// </summary>
        public virtual ICollection<Consultas> Consultas { get; set; }


    }
}
