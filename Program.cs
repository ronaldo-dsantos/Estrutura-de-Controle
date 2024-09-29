// ***** Estrutura de Controle *****

// if / else if / else
var diaDaSemana = 0;
var diaDeTrabalho = false;

if (diaDaSemana == 0 && !diaDeTrabalho)
{
  Console.WriteLine("Hoje é domingo e não é dia de trabalho");
}
else if (diaDaSemana == 0 && diaDeTrabalho)
{
  Console.WriteLine("Hoje é domingo, mas é dia de trabalho");
}
else
{
  Console.WriteLine("Hoje não é domingo");
}

diaDaSemana = 5;

if (diaDaSemana == 0)
{
  Console.WriteLine("Hoje é Domingo");
}
else if (diaDaSemana == 1)
{
  Console.WriteLine("Hoje é Segunda");
}
else if (diaDaSemana == 2)
{
  Console.WriteLine("Hoje é Terça");
}
else if (diaDaSemana == 3)
{
  Console.WriteLine("Hoje é Quarta");
}
else if (diaDaSemana == 4)
{
  Console.WriteLine("Hoje é Quinta");
}
else if (diaDaSemana == 5)
{
  Console.WriteLine("Hoje é Sexta");
}
else if (diaDaSemana == 6)
{
  Console.WriteLine("Hoje é Sábado");
}
else
{
  Console.WriteLine("Dia da semana inválido");
}

// Switch (Trata de apenas uma única entrada de dados)

diaDaSemana = 0;

switch (diaDaSemana)
{
  case 0:
    Console.WriteLine("Hoje é domingo");
    break;
  case 1:
    Console.WriteLine("Hoje é segunda");
    break;
  case 2:
    Console.WriteLine("Hoje é terça");
    break;
  case 3:
    Console.WriteLine("Hoje é quarta");
    break;
  case 4:
    Console.WriteLine("Hoje é quinta");
    break;
  case 5:
    Console.WriteLine("Hoje é sexta");
    break;
  case 6:
    Console.WriteLine("Hoje é sabado");
    break;
  default:
    Console.WriteLine("Dia da semana inválido");
    break;
}

// For
var lista = new List<string>() { "Ronaldo", "Domingues", "dos", "Santos" };

for (var i = 0; i < lista.Count; i++)
{
  Console.WriteLine(lista[i]);
}

// ForEach (Pode ser utilizado para fazer iteração sobre qualquer tipo de coleção, inclusive um cadeia de caracteres)
lista = new List<string>() { "Ronaldo", "Domingues", "dos", "Santos" };

foreach (string item in lista)
{
  Console.WriteLine(item); // No for precisamos informar o índice que queremos acessar, no foreach isso não é necessário
}

// Utilizando o foreach em uma cadeia de caracteres
var nome = "Ronaldo Domingues";

foreach (var item in nome) 
{
  Console.WriteLine(item);
}

// While
var index = 0;

while (index < 10) // Enquanto a condição for verdadeira, faça...
{
  Console.WriteLine(index);
  index++;
}

// Do While
index = 0;

do // Faça...
{
  Console.WriteLine(index);
  index++;
} while (index < 10); // Enquanto a condição for verdadeira, continue...

// Break / Continue
index = 0;

while (index < 10) 
{
  if (index < 2)
  {
    Console.WriteLine(index + " continue...");
    index++;
    continue; // Continue para ignorar a sequencia de intruções e voltar para o início, nesse caso para o início do while
  }

  Console.WriteLine(index);
  index++;

  if (index == 5)
  {
    Console.WriteLine(index + " pare!!!");
    break; // Break para forçar que a sequencia de instruções seja interrompida
  }
}