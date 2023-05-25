using mvc_console.Model;
using mvc_console.Controller;

//instância do objeto produto
Produto p = new Produto();

//instância do objeto produtoController
ProdutoController controller = new ProdutoController();

//chamada do método controlador de cadastro
controller.CadastrarProduto();

//chamada do método controlador de listagem
controller.ListarProdutos();