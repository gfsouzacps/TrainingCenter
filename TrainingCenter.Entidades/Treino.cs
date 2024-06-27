using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCenter.Entidades
{
    public class Treino
    {
        public Treino(int idTreino, string nome, DateTime dataTreino)
        {
            IdTreino = idTreino;
            Nome = nome;
            DataTreino = dataTreino;
        }
        public int IdTreino { get; set; }
        public string Nome { get; set; }
        public DateTime DataTreino { get; set; }
    }
}
