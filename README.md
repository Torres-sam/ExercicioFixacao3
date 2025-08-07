📚 ExercicioFixacao3 — Verificação de Aprovação
Este projeto é um exercício em C# que lê as notas do primeiro e segundo semestre de um aluno, calcula a nota final (como a soma das duas notas) e verifica se o aluno foi aprovado ou reprovado com base no total.

🚀 Funcionalidades
Solicita ao usuário as notas do primeiro e segundo semestre.

Calcula a nota final como soma das duas notas.

Aplica a regra:

Aprovado se nota final >= 60.00

Reprovado se nota final < 60.00

Exibe a nota final formatada com 1 casa decimal.

💻 Tecnologias Utilizadas
C# (.NET)

System.Globalization para formatação correta de números decimais.

📂 Estrutura do Código

Console.Write("Digite a nota do primeiro semestre: ");
double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite a nota do segundo semestre: ");
double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double resultado = nota1 + nota2;

if (resultado < 60.00) 
{
    Console.WriteLine("Nota Final " + resultado.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("Reprovado");
}
else 
{
    Console.WriteLine("Nota Final " + resultado.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("Aprovado");
}
🧮 Exemplo de Uso
Entrada:

Digite a nota do primeiro semestre: 27.0
Digite a nota do segundo semestre: 31.0
Saída:

Nota Final 58.0
Reprovado
📌 Observações
O critério de aprovação considera a nota final como a soma das duas notas.

Caso queira trabalhar com média, basta alterar o cálculo para:

double resultado = (nota1 + nota2) / 2;
E ajustar o critério de aprovação.
