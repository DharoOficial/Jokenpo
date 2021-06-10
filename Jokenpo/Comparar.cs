using System;
using System.Collections.Generic;
using System.Text;

namespace Jokenpo
{
    public class Comparar : IJokenpo
    {
        public void RetornoJogador1Venceu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("jogador 1 ganhou");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("jogador 2 perdeu");
            Console.ResetColor();
        }

        public void RetornoJogador2Venceu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("jogador 2 ganhou");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("jogador 1 perdeu");
            Console.ResetColor();
        }

        public void CompararJogadas(string player1, string player2)
        {

            if(player1 == player2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Empate");
                Console.ResetColor();
            }


            if(player1 == "pedra" && player2 == "tesoura" )
            {
                RetornoJogador1Venceu();
            }
            if (player1 == "pedra" && player2 == "papel")
            {
                RetornoJogador2Venceu();
            }
            if (player1 == "papel" && player2 == "tesoura")
            {
                RetornoJogador2Venceu();
            }
            if (player1 == "papel" && player2 == "pedra")
            {
                RetornoJogador1Venceu();
            }
            if (player1 == "tesoura" && player2 == "papel")
            {
                RetornoJogador1Venceu();
            }
            if (player1 == "tesoura" && player2 == "pedra")
            {
                RetornoJogador2Venceu();
            }

            //Logica em correção no primeiro caracter maiusulo
            if (player1 == "Pedra" && player2 == "Tesoura")
            {
                RetornoJogador1Venceu();
            }
            if (player1 == "Pedra" && player2 == "Papel")
            {
                RetornoJogador2Venceu();
            }
            if (player1 == "Papel" && player2 == "Tesoura")
            {
                RetornoJogador2Venceu();
            }
            if (player1 == "Papel" && player2 == "Pedra")
            {
                RetornoJogador1Venceu();
            }
            if (player1 == "Tesoura" && player2 == "Papel")
            {
                RetornoJogador1Venceu();
            }
            if (player1 == "Tesoura" && player2 == "Pedra")
            {
                RetornoJogador2Venceu();
            }
        }
    }
}
