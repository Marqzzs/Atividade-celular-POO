
// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using celular_poo;

Celular celular = new Celular();

celular.Ligar();

Console.WriteLine($"HELLO MOTO");

while (true)
{
    Console.WriteLine(@$"
=====================================
        MENU CELULAR
=====================================
    1. Fazer ligacao
    2. Mandar mensagem
    3. Desligar
=====================================
");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            celular.FazerLigacao();
            break;
        case "2":
            celular.Mensagem();
            break;
        default:
            Console.WriteLine($"Essa opção não é valida, tente novamente");
            break;
    }
    if (opcao == "3") { Console.WriteLine($"Desligando..."); break; }
}
