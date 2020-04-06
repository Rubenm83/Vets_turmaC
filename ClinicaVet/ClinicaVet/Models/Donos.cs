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
        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength(40, ErrorMessage = "O {0} só pode ter , no máximo,{1} caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Numero de indentificação fiscal do dono
        /// </summary>
        [Required]
        [StringLength(9, ErrorMessage = "O {0} só pode ter , no máximo,{1} caracteres.")]
        [Display(Name="Nº de Indentificação Fiscal")]
        [RegularExpression("[1-9][0-9]{8}", ErrorMessage = "Deverá introduzir o NIF corretamente, contendo 9 numeros")]
        public string NIF { get; set; }

        /// <summary>
        ///Lista dos animais que o Dono tem 
        /// </summary>
        
        public ICollection<Animais> ListaDeAnimais { get; set; } //Dono ---> Animais

    }
}
