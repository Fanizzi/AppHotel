using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Model
{
    internal class Hospedagem
    {
        int qnt_adultos;
        Suite quarto_escolhido;

        public Suite QuartoEscolhido
        {
            get { return quarto_escolhido; }

            set
            {
                if (value == null)
                    throw new Exception("Por favor, selecione sua acomodação");

                quarto_escolhido = value;
            }
        }

        public int QntAdultos
        {
            get { return qnt_adultos; }

            set
            {
                if (value == 0)
                    throw new Exception("Por favor, informe a quantidade de adultos");

                qnt_adultos = value;
            }
        }

        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }

        public double ValorTotal
        {
            get => ((QntAdultos * quarto_escolhido.DiariaAdulto) + (QntCriancas * quarto_escolhido.DiariaCrianca)) * Estadia;
        }
    }
}
