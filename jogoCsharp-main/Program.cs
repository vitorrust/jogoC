using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        // INTRODUÇÃO
        Console.WriteLine("Nickname do jogador 1: ");
        string nickJogador1 = Console.ReadLine();

        Console.WriteLine("Jogador 1 vs outro Jogador ou Maquina (J/M)");
        string player = Console.ReadLine();
        
        // PLAYER VS PLAYER
        if (player == "J")
        {
            Console.WriteLine("Nickname do jogador 2: ");
            string nickJogador2 = Console.ReadLine();

            int energyJg1 = 5;
            int energyJg2 = 5;

            // SORTEIO DE QUEM VAI COMEÇAR O JOGO
            Random objRand = new Random();
            int ordemJogador = objRand.Next(1, 3);
            int proximoJogador = ordemJogador;

            if (ordemJogador == 1)
            {
                Console.WriteLine("O jogador 1 comeca o jogo!");
            }
            else
            {
                Console.WriteLine("O jogador 2 começa o jogo!");
            }

            // LOOP ATÉ QUE ENERGIA SEJA 0
            while (energyJg1 > 0 && energyJg2 > 0)
            {

                Console.WriteLine("Digite R para sortear as cartas!");
                string start = Console.ReadLine();
                
                // SORTEIO RANDOM DAS CARTAS
                Random objCard = new Random();
                int sorteioCartas = objCard.Next(1, 4);

                Random objCard2 = new Random();
                int sorteioCartas2 = objCard2.Next(1, 4);

                Random objCard3 = new Random();
                int sorteioCartas3 = objCard3.Next(1, 4);

                string c1 = sorteioCartas.ToString();
                string c2 = sorteioCartas2.ToString();
                string c3 = sorteioCartas3.ToString();

                Console.WriteLine(c1 + c2 + c3);

                // ALTERNANCIA DOS JOGADORES
                if (ordemJogador == 1)
                {
                    proximoJogador = 2;
                }
                else
                {
                    proximoJogador = 1;
                }

                // CONDIÇÃO NA QUAL PELO MENOS 1 CARTA SEJA DIFERENTE
                if (c1 != c2 || c2 != c3 || c1 != c3)
                {
                    Console.WriteLine("O jogador " + ordemJogador + " perdeu uma energia");

                    if (ordemJogador == 1)
                    {
                        energyJg1 -= 1;
                    }
                    else
                    {
                        energyJg2 -= 1;
                    }

                    Console.WriteLine("Vez do jogador " + proximoJogador + "!");
                }
                else
                {
                    Console.WriteLine("O jogador não perdeu energia");
                    Console.WriteLine("Vez do jogador " + proximoJogador + "!");
                }
                ordemJogador = proximoJogador;
            
            // EXIBIR ENERGIAS DOS PLAYERS A CADA RODADA    
            Console.WriteLine("ENERGIAS DO JOGADOR 1: " + energyJg1);
            Console.WriteLine("ENERGIAS DO JOGADOR 2: " + energyJg2);
            }
            
            // EXIBIR VENCEDOR DA PARTIDA
            if (energyJg1 == 0)
            {
                Console.WriteLine("O JOGADOR " + nickJogador2+ " VENCEU A PARTIDA!");

            }else
            {
                Console.WriteLine("O JOGADOR " + nickJogador1 + " VENCEU A PARTIDA!");
            }
        }

        // PLAYER VS MAQUINA 
        else
        {
            int energyJg1 = 5;
            int energyMaquina = 5;

            Random objRand = new Random();
            int ordemJogador = objRand.Next(1, 3);
            int proximoJogador = ordemJogador;

            if (ordemJogador == 1)
            {
                Console.WriteLine("O jogador 1 comeca o jogo!");
            }
            else
            {
                Console.WriteLine("A máquina começa o jogo!");
            }

            while (energyJg1 > 0 && energyMaquina > 0)
            {

                Console.WriteLine("Digite R para sortear as cartas!");
                string start = Console.ReadLine();

                Random objCard = new Random();
                int sorteioCartas = objCard.Next(1, 4);

                Random objCard2 = new Random();
                int sorteioCartas2 = objCard2.Next(1, 4);

                Random objCard3 = new Random();
                int sorteioCartas3 = objCard3.Next(1, 4);

                string c1 = sorteioCartas.ToString();
                string c2 = sorteioCartas2.ToString();
                string c3 = sorteioCartas3.ToString();

                Console.WriteLine(c1 + c2 + c3);

                if (ordemJogador == 1)
                {
                    proximoJogador = 2;
                }
                else
                {
                    proximoJogador = 1;
                }

                if (c1 != c2 || c2 != c3 || c1 != c3)
                {
                    Console.WriteLine("O jogador " + ordemJogador + " perdeu uma energia");

                    if (ordemJogador == 1)
                    {
                        energyJg1 -= 1;
                    }
                    else
                    {
                        energyMaquina -= 1;
                    }

                    Console.WriteLine("Vez do jogador " + proximoJogador + "!");
                }
                else
                {
                    Console.WriteLine("O jogador não perdeu energia");
                    Console.WriteLine("Vez do jogador " + proximoJogador + "!");
                }
                ordemJogador = proximoJogador;
                Console.WriteLine("ENERGIAS DO JOGADOR 1: " + energyJg1);
                Console.WriteLine("ENERGIAS DA MAQUINA: " + energyMaquina);
            }

            //Console.WriteLine("O JOGADOR " + proximoJogador + " VENCEU A PARTIDA!");

            if (energyJg1 == 0)
            {
                Console.WriteLine("A MAQUINA VENCEU A PARTIDA!");

            }
            else
            {
                Console.WriteLine("O JOGADOR " + nickJogador1 + " VENCEU A PARTIDA!");
            }
        }
    }
}
