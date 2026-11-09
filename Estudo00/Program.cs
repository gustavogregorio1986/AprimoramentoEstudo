using System;
using System.Collections.Generic;
using System.Linq;
using Estudo00.Control;
using Estudo00.Entidade;

namespace Estudo00
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Lista expandida com 90 registros de alunos
            var alunos = new List<Aluno>
            {
                new Aluno("Laura", "Alvaro ramos", "4 serie", 4.5m, 8.9m),
                new Aluno("Luiz", "Alvaro ramos", "7 serie", 2.5m, 3.9m),
                new Aluno("Levy", "Pedro segundo", "1 serie do segundo grau", 10.0m, 1.1m),
                new Aluno("Matheus", "Escola municipal do RJ", "9 serie", 1.5m, 4.9m),
                new Aluno("Laio", "Alvaro pertim", "3 serie", 1.5m, 1.2m),
                new Aluno("Gabriel", "Colegio Alcantara", "2 serie", 9.5m, 10.9m), // Nota: ajustável se a escala for até 10
                new Aluno("Tacila", "Colegio Sacramentinas", "1 ano", 0.5m, 1.9m),
                new Aluno("Mario", "Colegio Alicerce bueno", "3 serie", 6.1m, 5.9m),
                new Aluno("Michel", "Colegio Alicerce bueno", "3 serie", 7.1m, 8.9m),
                new Aluno("Rafael", "Colegio Logosofico", "5 serie", 10.0m, 9.9m),
                new Aluno("Alberto", "Colegio Redes americas", "3 serie", 7.1m, 7.9m),
                new Aluno("Beatriz", "Alvaro ramos", "5 serie", 8.0m, 7.5m),
                new Aluno("Carlos", "Pedro segundo", "2 serie", 5.0m, 6.0m),
                new Aluno("Daniela", "Escola municipal do RJ", "8 serie", 9.0m, 9.5m),
                new Aluno("Eduardo", "Colegio Alcantara", "3 serie", 3.0m, 4.0m),
                new Aluno("Fernanda", "Colegio Sacramentinas", "2 ano", 7.0m, 8.0m),
                new Aluno("Gustavo", "Colegio Alicerce bueno", "4 serie", 6.5m, 5.5m),
                new Aluno("Helena", "Colegio Logosofico", "6 serie", 8.5m, 9.0m),
                new Aluno("Igor", "Colegio Redes americas", "1 serie", 4.0m, 3.5m),
                new Aluno("Juliana", "Alvaro ramos", "9 serie", 9.5m, 10.0m),
                new Aluno("Lucas", "Pedro segundo", "3 serie", 2.0m, 3.0m),
                new Aluno("Mariana", "Escola municipal do RJ", "4 serie", 7.5m, 8.5m),
                new Aluno("Nicolas", "Colegio Alcantara", "5 serie", 6.0m, 6.5m),
                new Aluno("Olivia", "Colegio Sacramentinas", "3 ano", 9.0m, 8.5m),
                new Aluno("Pedro", "Colegio Alicerce bueno", "2 serie", 5.5m, 4.5m),
                new Aluno("Quintino", "Colegio Logosofico", "7 serie", 8.0m, 8.0m),
                new Aluno("Rafaela", "Colegio Redes americas", "4 serie", 3.5m, 2.5m),
                new Aluno("Samuel", "Alvaro ramos", "8 serie", 10.0m, 9.5m),
                new Aluno("Tatiane", "Pedro segundo", "4 serie", 6.5m, 7.0m),
                new Aluno("Ulisses", "Escola municipal do RJ", "3 serie", 4.5m, 5.5m),
                new Aluno("Vanessa", "Colegio Alcantara", "1 serie", 8.5m, 8.0m),
                new Aluno("Wagner", "Colegio Sacramentinas", "4 ano", 1.5m, 2.0m),
                new Aluno("Ximena", "Colegio Alicerce bueno", "6 serie", 7.0m, 7.5m),
                new Aluno("Yuri", "Colegio Logosofico", "2 serie", 9.0m, 9.0m),
                new Aluno("Zuleica", "Colegio Redes americas", "5 serie", 5.0m, 5.0m),
                new Aluno("Alice", "Alvaro ramos", "3 serie", 8.0m, 9.0m),
                new Aluno("Bruno", "Pedro segundo", "6 serie", 3.0m, 2.5m),
                new Aluno("Camila", "Escola municipal do RJ", "7 serie", 7.5m, 7.0m),
                new Aluno("Diego", "Colegio Alcantara", "4 serie", 6.0m, 5.0m),
                new Aluno("Elaine", "Colegio Sacramentinas", "5 ano", 9.5m, 9.0m),
                new Aluno("Felipe", "Colegio Alicerce bueno", "1 serie", 4.0m, 4.5m),
                new Aluno("Gabriela", "Colegio Logosofico", "8 serie", 8.5m, 8.5m),
                new Aluno("Heitor", "Colegio Redes americas", "2 serie", 2.5m, 3.0m),
                new Aluno("Isabela", "Alvaro ramos", "6 serie", 7.0m, 8.0m),
                new Aluno("João", "Pedro segundo", "5 serie", 6.5m, 6.0m),
                new Aluno("Karina", "Escola municipal do RJ", "2 serie", 9.0m, 8.5m),
                new Aluno("Leonardo", "Colegio Alcantara", "9 serie", 5.5m, 5.0m),
                new Aluno("Monique", "Colegio Sacramentinas", "6 ano", 10.0m, 9.5m),
                new Aluno("Natanael", "Colegio Alicerce bueno", "7 serie", 3.5m, 4.0m),
                new Aluno("Patrícia", "Colegio Logosofico", "3 serie", 7.5m, 8.0m),
                new Aluno("Renato", "Colegio Redes americas", "6 serie", 6.0m, 7.0m),
                new Aluno("Sabrina", "Alvaro ramos", "1 serie", 8.0m, 8.5m),
                new Aluno("Thiago", "Pedro segundo", "4 serie", 1.0m, 2.0m),
                new Aluno("Viviane", "Escola municipal do RJ", "5 serie", 9.0m, 9.0m),
                new Aluno("William", "Colegio Alcantara", "3 serie", 4.5m, 4.0m),
                new Aluno("Amanda", "Colegio Sacramentinas", "7 ano", 7.0m, 6.5m),
                new Aluno("Bernardo", "Colegio Alicerce bueno", "5 serie", 5.5m, 6.0m),
                new Aluno("Carolina", "Colegio Logosofico", "4 serie", 8.5m, 9.0m),
                new Aluno("Danilo", "Colegio Redes americas", "7 serie", 2.0m, 1.5m),
                new Aluno("Evelyn", "Alvaro ramos", "2 serie", 9.5m, 9.5m),
                new Aluno("Fabio", "Pedro segundo", "8 serie", 6.5m, 5.5m),
                new Aluno("Giovanna", "Escola municipal do RJ", "6 serie", 7.5m, 8.0m),
                new Aluno("Humberto", "Colegio Alcantara", "1 serie", 3.0m, 3.5m),
                new Aluno("Ingrid", "Colegio Sacramentinas", "8 ano", 8.0m, 8.5m),
                new Aluno("Jonas", "Colegio Alicerce bueno", "4 serie", 5.0m, 4.5m),
                new Aluno("Larissa", "Colegio Logosofico", "9 serie", 10.0m, 10.0m),
                new Aluno("Marcelo", "Colegio Redes americas", "2 serie", 4.0m, 5.0m),
                new Aluno("Natalia", "Alvaro ramos", "3 serie", 7.0m, 7.5m),
                new Aluno("Otavio", "Pedro segundo", "7 serie", 6.0m, 6.5m),
                new Aluno("Priscila", "Escola municipal do RJ", "1 serie", 9.0m, 8.5m),
                new Aluno("Ricardo", "Colegio Alcantara", "4 serie", 1.5m, 2.5m),
                new Aluno("Simone", "Colegio Sacramentinas", "9 ano", 8.5m, 8.0m),
                new Aluno("Tulio", "Colegio Alicerce bueno", "6 serie", 5.5m, 5.0m),
                new Aluno("Valeria", "Colegio Logosofico", "5 serie", 9.5m, 9.0m),
                new Aluno("Wesley", "Colegio Redes americas", "3 serie", 3.5m, 3.0m),
                new Aluno("Adriana", "Alvaro ramos", "8 serie", 7.5m, 8.0m),
                new Aluno("Bruno", "Pedro segundo", "2 serie", 6.0m, 5.5m),
                new Aluno("Claudia", "Escola municipal do RJ", "4 serie", 8.0m, 8.5m),
                new Aluno("Douglas", "Colegio Alcantara", "7 serie", 2.5m, 3.0m),
                new Aluno("Elaine", "Colegio Sacramentinas", "1 ano", 9.0m, 9.5m),
                new Aluno("Frederico", "Colegio Alicerce bueno", "8 serie", 4.5m, 5.0m),
                new Aluno("Gisela", "Colegio Logosofico", "3 serie", 7.0m, 7.0m),
                new Aluno("Heitor", "Colegio Redes americas", "5 serie", 6.5m, 6.0m),
                new Aluno("Irina", "Alvaro ramos", "6 serie", 8.5m, 9.0m),
                new Aluno("Jorge", "Pedro segundo", "1 serie", 1.5m, 1.0m),
                new Aluno("Karen", "Escola municipal do RJ", "9 serie", 9.5m, 9.0m),
                new Aluno("Luciano", "Colegio Alcantara", "2 serie", 5.0m, 5.5m),
                new Aluno("Marcia", "Colegio Sacramentinas", "2 ano", 8.0m, 7.5m),
                new Aluno("Nelson", "Colegio Alicerce bueno", "4 serie", 3.0m, 4.0m),
                new Aluno("Priscila", "Colegio Logosofico", "6 serie", 7.5m, 8.0m)
            };

            ControlaAluno controlaAluno = new ControlaAluno();

            // Usando LINQ para separar os grupos
            var aprovados = alunos.Where(a => controlaAluno.Media(a) >= 7.0m).ToList();
            var recuperacao = alunos.Where(a => controlaAluno.Media(a) >= 5.0m && controlaAluno.Media(a) < 7.0m).ToList();
            var reprovados = alunos.Where(a => controlaAluno.Media(a) < 5.0m).ToList();

            // Exibindo Estatísticas Gerais de Contagem
            Console.WriteLine("==================================================");
            Console.WriteLine($"📊 RESUMO GERAL DA TURMA: Total de {alunos.Count} alunos");
            Console.WriteLine($"   - Aprovados: {aprovados.Count}");
            Console.WriteLine($"   - Em Recuperação: {recuperacao.Count}");
            Console.WriteLine($"   - Reprovados: {reprovados.Count}");
            Console.WriteLine("==================================================\n");

            // 1. Exibindo Aprovados
            Console.WriteLine("🟢 ALUNOS APROVADOS:");
            Console.WriteLine("--------------------------------------------------");
            foreach (var aluno in aprovados)
            {
                Console.WriteLine($"-> {aluno.Nome} | Média: {controlaAluno.Media(aluno):F1} | Escola: {aluno.Escola}");
            }

            // 2. Exibindo Recuperação
            Console.WriteLine("\n🟡 ALUNOS EM RECUPERAÇÃO:");
            Console.WriteLine("--------------------------------------------------");
            foreach (var aluno in recuperacao)
            {
                Console.WriteLine($"-> {aluno.Nome} | Média: {controlaAluno.Media(aluno):F1} | Escola: {aluno.Escola}");
            }

            // 3. Exibindo Reprovados
            Console.WriteLine("\n🔴 ALUNOS REPROVADOS:");
            Console.WriteLine("--------------------------------------------------");
            foreach (var aluno in reprovados)
            {
                Console.WriteLine($"-> {aluno.Nome} | Média: {controlaAluno.Media(aluno):F1} | Escola: {aluno.Escola}");
            }
        }
    }
}