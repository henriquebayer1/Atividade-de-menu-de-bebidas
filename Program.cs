Console.WriteLine(@"Escolha uma das seguintes bebidas com uma das letras representantes:
    -----------------------
    |    'F' Fanta       |
    |    'C' Coca Cola   |
    |    'D' Dolly       |
    |    'G' Guarana     |
    |    'A' Agua        |
    -----------------------
");

string escolhaDaBebida = Console.ReadLine();

Console.WriteLine($"Voce gostaria de gelo em sua bebida? digite sim ou nao");
string gelo = Console.ReadLine().ToLower();


switch (gelo)
{
    case "sim":
    Console.WriteLine($"Ao preparo de sua bebida iremos adicionar gelo.");
    
        break;
    default:
    Console.WriteLine($"Ok, nao sera adicionado gelo na sua bebida.");
    
        break;
}



switch (escolhaDaBebida)
{ case "F":
Console.WriteLine($"Sua Fanta sera preparada, Opcao de Gelo [{gelo}]");
break;
 case "C":
Console.WriteLine($"Sua Coca Cola sera preparada Opcao de Gelo [{gelo}]");
break;
 case "D":
Console.WriteLine($"Seu Dolly sera preparada Opcao de Gelo [{gelo}]");
break;
 case "G":
Console.WriteLine($"Seu Guarana sera preparada Opcao de Gelo [{gelo}]");
break;
 case "A":
Console.WriteLine($"Sua Agua sera preparada Opcao de Gelo [{gelo}]");
break;
    
    default:
    Console.WriteLine($"Nenhuma opcao apresentada foi escolhida, volte ao comeco do sistema para escolher uma das opcoes apresentada.");
    break;
   
    
}