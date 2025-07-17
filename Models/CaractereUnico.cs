using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Models
{
    public class CaractereUnico
    {
        private string? inputPrimeiro;
        private Dictionary<char, int> expressao = new Dictionary<char, int>();

        private bool CriacaoDicionario()
        {
            expressao.Clear();
            Console.WriteLine("\nDigite a expressão que deseja analisar:");
            inputPrimeiro = Console.ReadLine();
            if (string.IsNullOrEmpty(inputPrimeiro))
            {
                Console.WriteLine("null");
                return false;
            }
            int contador = 1;
            foreach (var item in inputPrimeiro)
            {
                bool tentativa = expressao.TryAdd(item, contador);
                if (!tentativa)
                {
                    expressao[item]++;
                }
            }
            return true;
        }

        public void ListarPrimeiroUnico()
        {
            if (!CriacaoDicionario()) return;
            var primeiroUnico = expressao.FirstOrDefault(x => x.Value == 1);
            if (primeiroUnico.Equals(default(KeyValuePair<char, int>)))
            {
                Console.WriteLine("\nNão existem caracteres únicos na expressão");
            }
            else
            {
                Console.WriteLine($"\nO primeiro caractere único é:\n{primeiroUnico.Key}" +
                $"\nE se encontra na posição:\n{inputPrimeiro!.IndexOf(primeiroUnico.Key) + 1}");
            }
            expressao.Clear();
        }

        public void ListarTodosUnicos()
        {
            if (!CriacaoDicionario()) return;
            var ordenado = expressao.OrderBy(x => x.Key).ToList();
            var unicos = expressao.Where(x => x.Value == 1).ToList();
            if (unicos.Count == 0)
            {
                Console.WriteLine("\nNão existem caracteres únicos na expressão");
            }
            else
            {
                Console.WriteLine("\nSegue abaixo todos os caracteres únicos encontrados na expressão:\n" +
                                  "(Em ordem alfabética)\n---------------");
                foreach (var item in ordenado)
                {
                    if (item.Value == 1)
                    {
                        Console.WriteLine(item.Key);
                    }
                }
                Console.WriteLine("---------------");
            }
            expressao.Clear();
        }

        public void FrequenciaCaracteres()
        {
            if (!CriacaoDicionario()) return;
            var ordenado = expressao.OrderBy(x => x.Key).ToList();
            Console.WriteLine("\n(Tabela em ordem alfabética)\n\n" +
                              "Caractere | Frequência\n" +
                              "----------------------");
            foreach (var elemento in ordenado)
            {
                Console.WriteLine($"{elemento.Key,-9} | {elemento.Value}\n" +
                                   "----------------------");
            }
            expressao.Clear();
        }

        public static void VoltarAoMenu()
        {
            Console.WriteLine("\nPressione Enter para voltar ao menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}