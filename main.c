/******************************************************************************

                            Online C Compiler.
                Code, Compile, Run and Debug C program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>



void ShowRecibo(){
    
}

void textIntro (){
  
  printf ("Selecione o tipo de pagamento para concluirmos a sua compra !!\n");
  printf ("1. Pix\n");
  printf ("2. Transferencia\n");
  printf ("3. Voucher\n");
  printf ("4. Cartão\n");
  printf ("5. Sair\n");
}

void PixPayment (float valorTotal){

  char* typedpassword;
  int i = 0;
  printf ("Chave Pix: jorge@gmail.com \n");
  printf ("Coloque a senha para realizar o pagamento no valor de %f \n", valorTotal);
  scanf("%s", typedpassword);
  
  while( i < 3) {
      
      if(typedpassword = "banana") {
            printf("Transição concluída com sucesso\n");
            ShowRecibo(valorTotal);
            return;
      }
      else{
          i++;
          printf("Senha incorreta, você ainda tem %d tentativas.\n", 3 - i);
          printf("Coloque a senha novamente: ");
          scanf("%s", typedpassword);
      }
  } 

    printf("Bloqueado");
}

void TransferenciaPayment(float valorTotal) {
    printf("Digite os detalhes da transferência para realizar o pagamento no valor de %.2f\n", valorTotal);
    // Lógica para pagamento por transferência
}

void VoucherPayment(float valorTotal) {
    printf("Digite o código do voucher para realizar o pagamento no valor de %.2f\n", valorTotal);
    // Lógica para pagamento com voucher
}

void CartaoPayment(float valorTotal) {
    printf("Insira os detalhes do cartão para realizar o pagamento no valor de %.2f\n", valorTotal);
    // Lógica para pagamento com cartão
}



int main (){
    
    static char * password = "banana";
    
  printf("%s", password);
  int opcao;
  float valorTotal;

  do{
	  printf("-----------------------------Seja bem vindo ao PayNet!!!!-----------------------------\n");
	  
	  printf ("Coloque o valor total de suas compras:");
	  scanf ("%f", &valorTotal);
	  
	  printf ("%.2f \n", valorTotal);

	  textIntro ();
	  scanf ("%d", &opcao);

	  switch (opcao){
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
		  printf ("Encerrando o programa.\n");
		  break;
		default:
		  printf
			("OpC'C#o invC!lida. Por favor, escolha uma opC'C#o vC!lida.\n");
		}

	}while (opcao != 5);

  return 0;
}



