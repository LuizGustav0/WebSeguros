using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSeguros.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "O veículo é usado para trabalhar?")]
        public String TrabalhaVei { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Possui garagem?")]
        public String Garagem { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Qual o tipo de seguro deseja?")]
        public String TipoSeguro { get; set; }

        //[Required(ErrorMessage = "{0} é obrigatório")]
        //[RegularExpression("^((?!^ESCOLHA UMA MARCA$)[a-zA-Z '])+$", ErrorMessage = "Selecione a marca do seu veículo.")]
        public String Marca { get; set; }

        //[Required(ErrorMessage = "{0} é obrigatório")]
        //[RegularExpression("^((?!^ESCOLHA UM MODELO$)[a-zA-Z '])+$", ErrorMessage = "Selecione o modelo do seu veículo.")]
        public String Modelo { get; set; }

        //[Required(ErrorMessage = "{0} é obrigatório")]
        //[RegularExpression("^((?!^ESCOLHA O ANO$)[a-zA-Z '])+$", ErrorMessage = "Selecione o ano do seu veículo.")]
        public String Ano { get; set; }

        public String Placa { get; set; }

        public String Cor { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Valor do veículo segundo a tabela FIPE")]
        public String ValorVeiculo { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "O valor do seguro é")]
        public String ValorSeguro { get; set; }
        public int IdCliente { get; set; }
    }
}
