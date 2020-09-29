using System;

class Hamburguer
{
  
  private string pao;
  private string carne = "";
  private string queijo = "";
  private string adicionais = "";
  private double preco = 0.00;

  public void EscolhePao () {
    int aux;
    do{
    Console.WriteLine ("Digite o codigo do pão desejado: \n| 1-Tradicional=R$1,50 | 2-Frances=R$2,00 | 3-Australiano=R$2,50 | 4-Tradicional+Gergelim=R$2,00 | 5-Tapioca=R$2,50 |");
    aux = Convert.ToInt32(Console.ReadLine());
    switch (aux){
      case 1: pao = "Tradicional";
      Console.WriteLine("Pão Escolhido {0}.\n", pao);
      preco = (preco+1.5);
      break;
      case 2: pao = "Frances";
      Console.WriteLine("Pão Escolhido {0}.\n", pao);
      preco = (preco+2.0);
      break;
      case 3: pao = "Australiano";
      Console.WriteLine("Pão Escolhido {0}.\n", pao);
      preco = (preco+2.5);
      break;
      case 4: pao = "Tradicional + Gergelim";
      Console.WriteLine("Pão Escolhido {0}.\n", pao);
      preco = (preco+2.0);
      break;
      case 5: pao = "Tapioca";
      Console.WriteLine("Escolhido {0}.\n", pao);
      preco = (preco+2.5);
      break;
      default: Console.WriteLine("Opção invalida, digite uma das opções validas! \n");
      break;
    }
    }while(aux<0 || aux>6);

  }

  public void EscolheCarne(){
    int aux;
    bool adCarne=true;
    do{
      do{
      Console.WriteLine ("Digite o codigo da carne desejada: \n| 1-Tradicional 150g=R$3,00 | 2-Picanha 150g=R$4,50 | 3-Frango 150g=R$3,00 |4-Tradicional Smash 100g=R$2,00 |");
      aux = Convert.ToInt32(Console.ReadLine());
      switch (aux){
        case 1: carne = carne + "Tradicional 150g ; ";
        Console.WriteLine("Carne Escolhida - {0}.\n", carne);
        preco = (preco+3.0);
        break;
        case 2: carne = carne + "Picanha 150g ; ";
        Console.WriteLine("Carne Escolhida - {0}.\n", carne);
        preco = (preco+4.5);
        break;
        case 3: carne = carne + "Frango 150g ; ";
        Console.WriteLine("Carne Escolhida - {0}.\n", carne);
        preco = (preco+3.0);
        break;
        case 4: carne = carne + "Tradicional Smash 100g ; ";
        Console.WriteLine("Carne Escolhida - {0}.\n", carne);
        preco = (preco+2.0);
        break;
        default: Console.WriteLine("Opção invalida, digite uma das opções validas! \n");
        break;
        }
      }while(aux<1 || aux>4);
      adCarne=false;
      Console.WriteLine("Deseja adicionar outra carne? (s-SIM || n-NÂO)");
      if(Console.ReadLine()=="s"){
        adCarne=true;
      }
    }while(adCarne==true);
  }

  public void EscolheQueijo(){
    int aux;
    bool adQueijo=true;
    do{
      do{
      Console.WriteLine ("Digite o codigo do queijo desejado: \n| 1-Cheddar=R$2,00 | 2-Mussarela=R$1,50 | 3-Gorgonzola=R$2,50 | 4-Nenhum |");
      aux = Convert.ToInt32(Console.ReadLine());
      switch (aux){
        case 1: queijo = queijo + "Cheddar ; ";
        Console.WriteLine("Queijo Escolhido - {0}.\n", queijo);
        preco = (preco+2.0);
        break;
        case 2: queijo = queijo + "Mussarela ; ";
        Console.WriteLine("Queijo Escolhido - {0}.\n", queijo);
        preco = (preco+1.5);
        break;
        case 3: queijo = queijo + "Gorgonzola ; ";
        Console.WriteLine("Queijo Escolhido - {0}.\n", queijo);
        preco = (preco+2.5);
        break;
        case 4: queijo = "Sem queijo ; ";
        Console.WriteLine("Queijo Escolhido - {0}.\n", queijo);
        break;
        default: Console.WriteLine("Opção invalida, digite uma das opções validas! \n");
        break;
        }
      }while(aux<1 || aux>4);
      adQueijo=false;
      if(aux!=4){
        Console.WriteLine("Deseja adicionar outra queijo? (s-SIM || n-NÂO)");
        if(Console.ReadLine()=="s"){
          adQueijo=true;
        }
      }
    }while(adQueijo==true);
  }

  public void EscolheAdicionais(){
    int aux;
    bool adAdicionais=true;
    do{
      do{
      Console.WriteLine ("Digite o codigo dos adicionais desejados: \n| 1-Bacon=R$2,50 | 2-Onion Rings=R$3,00 | 3-Cebola Caramelizada=R$2,00 | 4-Banana Frita=R$2,00 | 5-Salada=R$1,50 | 6-Barbecue=R$2,00 | 7-Sem Adicionais |");
      aux = Convert.ToInt32(Console.ReadLine());
      switch (aux){
        case 1: adicionais = adicionais + "Bacon ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        preco = (preco+2.5);
        break;
        case 2: adicionais = adicionais + "Onion Rings ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        preco = (preco+3.0);
        break;
        case 3: adicionais = adicionais + "Cebola Caramelizada ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        preco = (preco+2.0);
        break;
        case 4: adicionais = adicionais + "Banana Frita ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        preco = (preco+2.0);
        break;
        case 5: adicionais = adicionais + "Salada ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        preco = (preco+1.5);
        break;
        case 6: adicionais = adicionais + "Barbecue ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        preco = (preco+2.0);
        break;
        case 7: adicionais = "Sem adicionais ; ";
        Console.WriteLine("Adicionais Escolhidos - {0}.\n", adicionais);
        break;
        default: Console.WriteLine("Opção invalida, digite uma das opções validas! \n");
        break;
        }
      }while(aux<1 || aux>7);
      adAdicionais=false;
      if(aux!=7){
        Console.WriteLine("Deseja acrescentar outro adicional? (s-SIM || n-NÂO)");
        if(Console.ReadLine()=="s"){
          adAdicionais=true;
        }
      }
    }while(adAdicionais==true);
  }

  public double RetornaPreco(){
    return preco;
  }

}