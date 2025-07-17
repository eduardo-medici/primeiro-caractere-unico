// Desafio: Criar um programa capaz de receber uma string e retornar a primeira instância de caractere que não se repete.
//          Caso todos os caracteres se repetem na string, retornar "null"
// Exemplo 1: Insere -> aajejenciewpcn
//            Retorna -> i
// Exemplo 2: Insere -> 112233445566
//            Retorna -> null OU outra expressão alertando a falha

using Models;
CaractereUnico carUni = new CaractereUnico();
bool ciclo = true;

while (ciclo)
{
    Console.WriteLine("Escolha uma operação:\n" +
                      "(Digite 1) Para encontrar o primeiro caractere único de uma expressão\n" +
                      "(Digite 2) Para encontrar todos os caracteres únicos de uma expressão\n" +
                      "(Digite 3) Para encontrar a frequência de cada caractere na expressão\n" +
                      "(Digite 4) Para encerrar o programa");

    string? operacao = Console.ReadLine();

    switch (operacao)
    {
        case "1":
            carUni.ListarPrimeiroUnico();
            CaractereUnico.VoltarAoMenu();
            break;
        case "2":
            carUni.ListarTodosUnicos();
            CaractereUnico.VoltarAoMenu();
            break;
        case "3":
            carUni.FrequenciaCaracteres();
            CaractereUnico.VoltarAoMenu();
            break;
        case "4":
            ciclo = false;
            break;
        default:
            Console.WriteLine("Valor inválido");
            CaractereUnico.VoltarAoMenu();
            break;
    }
}





