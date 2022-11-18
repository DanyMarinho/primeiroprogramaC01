const string textoolamundo = "Olá mundo, esse é o meu primeiro programa C# feito por";
string nomecompleto;
int idade;
Console.WriteLine("Qual o seu nome completo?");
nomecompleto = Console.ReadLine().ToString();
Console.WriteLine("Qual a sua idade");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(textoolamundo + nomecompleto + "que tem" + idade + "anos");