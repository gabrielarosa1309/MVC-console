using mvc_console.Model;
using mvc_console.Controller;

//instância do objeto produto
Produto p = new Produto();

//instância do objeto produtoController
ProdutoController controller = new ProdutoController();

//chamada do método controlador
controller.ListarProdutos();