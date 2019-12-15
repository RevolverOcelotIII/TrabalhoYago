using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabYago.Models
{
    public class Placar
    {
        public int Id { get; set; }

        [Display(Name = "Jogador que marcou")]
        public string JogadorNome { get; set; }
        [Display(Name = "Total de pontos")]
        public uint TotalPontos { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data da pontuação")]
        public DateTime DataPontuacao { get; set; }
    }
}
