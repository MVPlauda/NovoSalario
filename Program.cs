internal class Program
{
    private static void Main(string[] args)
    {

        int codigo;
        double novoSalario, salario;

        Console.WriteLine("Informe o salário: ");
        salario = double.Parse(Console.ReadLine()); 

        Console.WriteLine("informe o codigo (1 - gerente / 2 -engenheiro / 3 - tecnico / 4 - supervisor: ");
        codigo = int.Parse(Console.ReadLine());

        switch (codigo) 
        {
            case 1:
                novoSalario = salario * 1.1; // calcula o novo salário com um aumento de 10%
                Console.WriteLine($"salario antigo: R${salario}\nNovo salário: R${novoSalario}\nDiferença: {novoSalario - salario} reais."); // imprime o salário antigo, novo salário e a diferença de salário
                break;

            case 2:
                novoSalario = salario * 1.2; // calcula o novo salário com um aumento de 20%
                Console.WriteLine($"salario antigo: R${salario}\nNovo salário: R${novoSalario}\nDiferença: {novoSalario - salario} reais."); // imprime o salário antigo, novo salário e a diferença de salário
                break;

            case 3:
                novoSalario = salario * 1.3; // calcula o novo salário com um aumento de 30%
                Console.WriteLine($"salario antigo: R${salario}\nNovo salário: R${novoSalario}\nDiferença: {novoSalario - salario} reais."); // imprime o salário antigo, novo salário e a diferença de salário
                break;

            case 4:
                novoSalario = salario * 1.1; // calcula o novo salário com um aumento de 10%
                Console.WriteLine($"salario antigo: R${salario}\nNovo salário: R${novoSalario}\nDiferença: {novoSalario - salario} reais."); // imprime o salário antigo, novo salário e a diferença de salário
                break;

            default:
                Console.WriteLine($"Salário com 40% de aumento {salario * 1.4}"); // caso o código não seja nenhum dos anteriores, o novo salário é calculado com um aumento de 40%
                break;
        }
    }
}
