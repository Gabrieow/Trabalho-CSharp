namespace Exercicios
{
    public class ToDoList
    {
        private List<string> tarefas = new List<string>();

        public void Iniciar()
        {
            Console.WriteLine("\n--- LISTA DE AFAZERES ---");
            Console.WriteLine("Opções:\n1 - Adicionar tarefa\n2 - Visualizar tarefas\n3 - Marcar tarefa como concluída\n4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarTarefa();
                    break;
                case "2":
                    VisualizarTarefas();
                    break;
                case "3":
                    MarcarComoConcluida();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AdicionarTarefa()
        {
            // adiciona tarefa na List "tarefas"
            Console.Write("Digite a nova tarefa: ");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada.");
        }

        private void VisualizarTarefas()
        {
            // condicional pra caso não exista tarefas, retornar um "erro"/aviso
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            // se existir tarefas, vai emitir todas na tela
            Console.WriteLine("\n- TAREFAS -\n");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }

        private void MarcarComoConcluida()
        {   
            // chamando o método pra mostrar as tarefas
            VisualizarTarefas();

            Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
            string entrada = Console.ReadLine();

            // usando TryParse pra tratamento de erros e excessões, ele recebe a entrada, retorna um índice que tem que ser maior que 0 e menor que a quantidade de tarefas na lista
            if (int.TryParse(entrada, out int indice) && indice > 0 && indice <= tarefas.Count)
            {
                // se o índice for aprovado, ele acrescenta " - CONCLUÍDA" na tarefa escolhida dentro da lista
                tarefas[indice - 1] += " - CONCLUÍDA";
                Console.WriteLine("Tarefa marcada como concluída.");
            }
            else
            {
                // se o índice não for aprovado, ele retorna "número inválido"
                Console.WriteLine("Número inválido.");
            }
        }
    }
}
