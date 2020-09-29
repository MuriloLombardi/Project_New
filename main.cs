using System;

class MainClass {
  public static void Main () {
    
    Hamburguer lanche = new Hamburguer(); 
    Pedido comanda = new Pedido();


    comanda.NomeCliente();
    lanche.EscolhePao();
    lanche.EscolheCarne();
    lanche.EscolheQueijo();
    lanche.EscolheAdicionais();
    comanda.Pagamento(lanche.RetornaPreco());


  }
}