using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truco
{
    internal class Mesa
    {
        Cartas[] cartas;
        Stack<Cartas> pilhaBaralho;
        Random rand = new Random();
        public void CriarCartas()
        {
            string[] naipe = {"Paus","Copas","Espada","Ouros"};
            char[] numero = {'4','5','6','7','Q','J','K', 'A', '2', '3' };
            int valor = 1, quantidade = 1;
            cartas = new Cartas[40];

            for (int i = 0; i < numero.Length; i++)
            {
                for(int j = 0; j < naipe.Length; j++)
                {
                    if (numero[i] == '4' && naipe[j] == "Paus")
                        cartas[quantidade++] = new Cartas(naipe[j], numero[i], 4000);
                    else if (numero[i] == '7' && naipe[j] == "Copas")
                        cartas[quantidade++] = new Cartas(naipe[j], numero[i], 3000);
                    else if (numero[i] == 'A' && naipe[j] == "Espadas")
                        cartas[quantidade++] = new Cartas(naipe[j], numero[i], 2000);
                    else if (numero[i] == '7' && naipe[j] == "Ouros")
                        cartas[quantidade++] = new Cartas(naipe[j], numero[i], 1000);
                    else
                        cartas[quantidade++] = new Cartas(naipe[j], numero[i], valor++);
                }
            }
        }

        public int NumeroAleatorio()
        {
            int [] numero = new int[40];
            
            for (int i = 0; i < cartas.Length; i++)
            {
                int numeroDiferente = rand.Next(0, 40);
                if (NumeroRepitido() == false)
                {

                }

            }
        }

        public int NumeroRepitido()
        {

        }

        public void CriaBaralho()
        {
            pilhaBaralho = new Stack<Cartas>();

            for (int i = 0; i < cartas.Length; i++)
            {
                pilhaBaralho.Push(cartas[i]);
            }
        }
    }
}
