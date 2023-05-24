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
    }
}