string titulo;
string descricao;
string dataVencimento;

titulo = Console.ReadLine();
descricao = Console.ReadLine();

if (descricao.Length < 50)
{
    dataVencimento = Console.ReadLine();
    Console.WriteLine(descricao + " ate " + dataVencimento );
}
else
{ 
    Console.WriteLine("Descricao ultrapassa limite de caracteres.");
}               
          
        
    