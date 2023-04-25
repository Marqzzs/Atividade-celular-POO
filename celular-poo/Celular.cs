using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace celular_poo
{
    public class Celular
    {
        //  com as propriedades cor, modelo, tamanho, ligado(booleano)
        public string Cor;
        public string Modelo;
        public string Tamanho;

        // Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.

        public void Ligar()
        {
            string resposta;
            do
            {
                Console.WriteLine($"Vai ligar o celular? (s/n)");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "s") { Console.WriteLine($"Ligando aparelho"); }
                else if (resposta == "n") { Console.WriteLine($"Celular desligado"); }

            } while (resposta == "n");
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando o tijolo...");           
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"Selecione o contato desejado:");
            Console.WriteLine($"");
            Console.WriteLine($"Contato selecionado.");
            Console.WriteLine($"");
            Console.WriteLine($"Ligando para o contato...");
            Console.WriteLine($"");
        }

        public void Mensagem()
        {
            Console.WriteLine($"Entrando no zapzap...");
            Console.WriteLine($"");
            Console.WriteLine($"Vai mandar mensagem para seu amorzinho? rsrs☺");
            Console.WriteLine($"");
            Console.WriteLine($"Mensagem enviada");
            Console.WriteLine($"");
        }
    }
}