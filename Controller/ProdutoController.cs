using mvc_console.Model;
using mvc_console.View;

namespace mvc_console.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //método controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //lista de produtos chamada pela model
            List<Produto> produtos = produto.Ler();

            //chamada do método de exibição (view) recebendo como argumento a lista
            produtoView.Listar(produtos);
        }
    }
}