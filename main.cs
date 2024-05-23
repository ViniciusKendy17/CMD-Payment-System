  // See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static string password = "banana";
    static string user = "Vinicius";
    static string cpf = "882.234.666-33";
    static string contatype = "Corrente";

    enum Metodos {Pix, Ted, Voucher, Cartão};   

    static void ShowRecibo(float valorTotal, Metodos type)
    {
        Console.WriteLine("");
        Console.WriteLine("--------------------------RECIBO---------------------------\n");
        Console.WriteLine($"Data de pagamento: {DateTime.Now.ToString("D")}");
        Console.WriteLine($"Pagante: {user}");
        Console.WriteLine($"CPF do pagante: {cpf}");
        Console.WriteLine($"Tipo de pagamento: {type}");
        Console.WriteLine($"Tipo de conta: {contatype}");
        Console.WriteLine($"Valor total: R${valorTotal}");
        Console.WriteLine("");
    }

    static void TextIntro()
    {
        Console.WriteLine("");
        Console.WriteLine("Selecione o tipo de pagamento para concluirmos a sua compra !!");
        Console.WriteLine("1. Pix");
        Console.WriteLine("2. Transferencia");
        Console.WriteLine("3. Voucher");
        Console.WriteLine("4. Cartão");
        Console.WriteLine("5. Sair");
    }

    static void Validation()
    {
        int i = 0;
        while (i != 3)
        {
            Console.WriteLine("");
            Console.WriteLine($"Coloque a senha para realizar o pagamento no valor de R${valorTotal:F2}");
            string typedpassword = Console.ReadLine();

            if (typedpassword == password)
            {
                Console.WriteLine("");
                Console.WriteLine("TRANSAÇÃO FEITA COM SUCESSO");
                
                return;
            }
            else
            {
                i++;
                Console.WriteLine("");
                Console.WriteLine($"Senha incorreta, você ainda tem {3 - i} tentativas.");
            }
        }
        Console.WriteLine("Bloqueado");
        Environment.Exit(0);
    }

    static void PixPayment(float valorTotal)
    {
        Metodos type = Metodos.Pix;
        Validation();
        ShowRecibo(valorTotal, type);

    }

    static void TransferenciaPayment(float valorTotal)
    {
        Metodos type = Metodos.Ted;
        Validation();
        ShowRecibo(valorTotal, type);
    }

    static void VoucherPayment(float valorTotal)
    {
        Console.WriteLine($"Digite o código do voucher para realizar o pagamento no valor de R${valorTotal:F2}");
        // Lógica para pagamento com voucher
    }

    static void CartaoPayment(float valorTotal)
    {
        Metodos type = Metodos.Cartão;
        Validation();
        ShowRecibo(valorTotal, type);

    }
    static float valorTotal;
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("-----------------------------Seja bem vindo ao PayNet!!!!-----------------------------");

            Console.WriteLine("Coloque o valor total de suas compras: R$");
            valorTotal = float.Parse(Console.ReadLine());

            TextIntro();
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:               
                    PixPayment(valorTotal);
                    break;
                case 2:
                    TransferenciaPayment(valorTotal);
                    break;
                case 3:
                    VoucherPayment(valorTotal);
                    break;
                case 4:
                    CartaoPayment(valorTotal);
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        } while (opcao != 5);
    }
}

