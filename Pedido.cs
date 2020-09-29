using System;

class Pedido
    {
      private string cliente;
      private double valorTotal;
      private double valorPago;
      private double troco;
      
      public void NomeCliente(){
        Console.WriteLine("Digite o seu nome: ");
        cliente = Console.ReadLine();
      }

      public void Pagamento(double precoLanche){
        bool aux = false;

        valorTotal = precoLanche;
        Console.WriteLine("Preço do lanche:  {0}\n", valorTotal);
        while(aux==false){
        Console.WriteLine("Digite o valor pago: ");
        valorPago = Convert.ToDouble(Console.ReadLine());
        troco = (valorPago-valorTotal);
        if(troco>=0.00){
          Console.WriteLine("Troco: {0} \n", troco);
          aux = true;
          }else if(troco<0.00){
            Console.WriteLine("Valor pago inferior ao valor devido.\n");
          }
        }

      }

    }