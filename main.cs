// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static string password = "banana";
    static string user = "Vinicius";
    static string cpf = "882.234.666-33";
    static string contatype = "Corrente";

    static bool useVoucher = false;
    static float valorTotal;
    static float valor;

    enum Metodos {Pix, Ted, Voucher, Cartão}; 
    enum Vouchers {v1 = 5, v2 = 10, v3 = 20};

    static void ShowRecibo(float valorTotal, Metodos type)
    {
        Console.WriteLine("");
        Console.WriteLine("--------------------------RECIBO---------------------------\n");
        Console.WriteLine($"Data de pagamento: {DateTime.Now.ToString("D")}");
        Console.WriteLine($"Pagante: {user}");
        Console.WriteLine($"CPF do pagante: {cpf}");
        Console.WriteLine($"Tipo de pagamento: {type}");
        Console.WriteLine($"Tipo de conta: {contatype}");
        Console.WriteLine($"Voucher: {useVoucher}");
        Console.WriteLine($"Valor total: R${valorTotal}");
        Console.WriteLine("");
    }

    static void TextIntro()
    {
        Console.WriteLine("");
        Console.WriteLine("Selecione o tipo de pagamento para concluirmos a sua compra !!");
        Console.WriteLine("1. Pix");
        Console.WriteLine("2. Transferencia");
        Console.WriteLine("3. Cartão");
        Console.WriteLine("4. Sair");
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

    static void CartaoPayment(float valorTotal)
    {
        Metodos type = Metodos.Cartão;
        Validation();
        ShowRecibo(valorTotal, type);

    }
    
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("-----------------------------Seja bem vindo ao PayNet!!!!-----------------------------");

            Console.WriteLine("Coloque o valor total de suas compras: R$");
            valorTotal = float.Parse(Console.ReadLine());

            Console.WriteLine("Deseja usar um voucher ? [1]Sim e [2]Não");
            int resp = Convert.ToInt16(Console.ReadLine());

            if (resp == 1)
            {
                useVoucher = true;
                Console.WriteLine("Selecione um dos vouchers disponiveis:");
                Console.WriteLine("[1]v1 - 5% de desconto");
                Console.WriteLine("[2]v2 - 10% de desconto");
                Console.WriteLine("[3]v3 - 20% de desconto");

                int vouchernum = Convert.ToInt16(Console.ReadLine());


                switch (vouchernum)
                {
                    case 1:
                        valorTotal  = (valorTotal) - (valorTotal/100 * 5);
                        Console.WriteLine($"Novo valor: {valorTotal}");
                        break;
                    case 2:
                        valorTotal = (valorTotal) - (valorTotal / 100 * 10);
                        Console.WriteLine($"Novo valor: {valorTotal}");
                        break;
                    case 3:
                        valorTotal = (valorTotal) - (valorTotal / 100 * 20);
                        Console.WriteLine($"Novo valor: {valorTotal}");
                        break;
                }
                    
            }
            else
            {
                valorTotal = valorTotal;
            }

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
                    CartaoPayment(valorTotal);
                    break;
                case 4:
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        } while (opcao != 5);
    }
}

