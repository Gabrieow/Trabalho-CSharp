namespace Exercicios
{
    public class Produto
    {
        // getters e setters
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        // construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // método pra calcular estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
    }
    public class CadastroDeProdutos
    {
        public void CadastrarProdutos()
        {
            // inicializando lista de produtos
            List<Produto> produtos = new List<Produto>();

            // laço de repetição pra cadastrar 3 produtos
            for (int i = 1; i <= 3; i++)
            {

            Console.WriteLine($"Cadastro do {i}º Produto.\n\n")

            Console.WriteLine("Insira o nome do produto: ");
            string nome = console.ReadLine();

            Console.WriteLine("Insira o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            // depois que recebe os 3 atributos, a gente instancia a classe produto e atribui os valores pra ela
            Produto produto = new Produto(nome, preco, quantidade);
            // depois adiciona na lista q criamos
            produtos.Add(produto);
            }

            Console.WriteLine("Produtos cadastrados: ");

            // aqui é um foreach pra percorrer cada produto dentro da lista produtos
            foreach (var produto in produtos)
            {
                Console.WriteLine(
                    $"Nome: {produto.Nome}\n
                    Preço: R${produto.Preco}\n
                    Quantidade: {produto.Quantidade}\n\n
                    Total em estoque: R${produto.ValorTotalEmEstoque()}");
            }
        }
    }
}