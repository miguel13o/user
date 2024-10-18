string mes = "";
int dias = 0;

Console.WriteLine("---------------");
Console.WriteLine("Dias de um mes");
Console.WriteLine("---------------\n");

Console.Write("informe o mes por extenso:");
mes = Console.ReadLine()!.ToUpper();

switch(mes)
{
    case "JANEIRO":
        dias = 31;
        break;
    case "FEVEREIRO":
        dias = 28;
        break;
    case "MARCO":
        dias = 31;
        break;
    case "ABRIL":
        dias = 30;
        break;
    case "MAIO":
        dias = 31; 
        break;
    case "JUNHO":
        dias = 30;
        break;
    case "JULHO":
        dias = 31;
        break;
    case "AGOSTO":
        dias = 30;
        break;
    case "SETEMBRO":
        dias = 30; 
        break;
     case "OUTUBRO":
        dias = 31; 
        break;
     case "NOVEMBRO":
        dias = 31; 
        break;
     case "DEZEMBRO":
        dias = 31; 
        break;
    
    default:
    Console.WriteLine("mes invalido");
    break;
}

if (dias > 0)
{
    Console.WriteLine($"mes do {mes} possui {dias} dias");
}