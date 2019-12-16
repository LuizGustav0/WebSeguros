using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace WebSeguros.Models
{
        
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} tamanho deve ser entre {2} e {1}")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [DateMinimumAge(18, ErrorMessage = "{0} é obrigatório ter mais de {1} anos")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DataNascimento { get; set; }

        
        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "CPF")]
        public String Cpf { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Sexo")]
        public String Sexo { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Estado Civil")]
        public String EstadoCivil { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public String Celular { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Adicione um e-mail válido")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }


        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")] 
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Nº é obrigatório")]
        [Display(Name = "Nº")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")] 
        public String Bairro { get; set; }

        public String Uf { get; set; }


    }

    public class DateMinimumAgeAttribute : ValidationAttribute
    {
        public DateMinimumAgeAttribute(int minimumAge)
        {
            MinimumAge = minimumAge;
            ErrorMessage = "{0} must be someone at least {1} years of age";
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if ((value != null && DateTime.TryParse(value.ToString(), out date)))
            {
                return date.AddYears(MinimumAge) < DateTime.Now;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, MinimumAge);
        }

        public int MinimumAge { get; }
    }
}
