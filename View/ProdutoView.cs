using mvc_console.Model;

namespace mvc_console.View
{
    public class ProdutoView
    {
        //método para exibir os dados da lista de produtos
        public void Listar(List<Produto> produto)
        {
            Console.Clear();

            //foreach para ler a lista passada como parâmetro do método
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
            }
        }

        //método para cadastrar produtos
        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.Write($"Informe o código:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Informe o nome:");
            novoProduto.Nome = Console.ReadLine();
            Console.Write($"Informe o preço:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }
    }
}