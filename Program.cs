using CRUD2;

string item;
int resposta;
int i;


Produto produto1 = new Produto();
Console.WriteLine("Bem vindo! Deseja adicionar quantos produtos? ");
resposta = int.Parse(Console.ReadLine());
List<Produto> listaProdutos2 = new List<Produto>(resposta);
for (i = 0; i < resposta; i++)
{
    Console.Write("Digite o nome do produto: ");
    item = Console.ReadLine();
    produto1.Nome = item;
    listaProdutos2.Add(produto1);
}

for (int x = 0; x < resposta; x++)
{
    Console.WriteLine(listaProdutos2);
}

Console.WriteLine("Esses são os produtos! Gostaria de remover ou alterar algum item?");
Console.WriteLine("Remover - Digite 1");
Console.WriteLine("Alterar - Digite 2");
int resposta2 = int.Parse(Console.ReadLine());

switch (resposta2)
{
    case 1:
        Console.WriteLine("Qual produto deseja remover? ");
        item = Console.ReadLine();
        produto1.Nome = item;
        listaProdutos2.Remove(produto1);
        
        break;

        case 2:
        Console.Write("Digite o nome do produto a ser alterado: ");
        item = Console.ReadLine();
        produto1.Nome = item;
        listaProdutos2.Add(produto1);
        break;
}