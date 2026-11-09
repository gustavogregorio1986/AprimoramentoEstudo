using System;
using System.Collections.Generic;
using Estudo0.Entidade;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criando um cadastro geral de Escolas
        var escolas = new List<Escola>
        {
            new Escola { NomeEscola = "Colégio Central", CnpjEscola = "12.345.678/0001-90" },
            new Escola { NomeEscola = "Escola Estadual Amanhã", CnpjEscola = "98.765.432/0001-12" },
            new Escola { NomeEscola = "Instituto Saber", CnpjEscola = "45.123.789/0001-55" }
        };

        // 2. Criando um cadastro geral de Professores e associando às escolas existentes
        var professores = new List<Professor>
        {
            new Professor
            {
                NomeProf = "Carlos Silva",
                EmailProf = "carlos@email.com",
                CpfProf = "123.456.789-00",
                QutdeAulas = 20,
                // O Professor Carlos leciona no Colégio Central e na Escola Amanhã
                Escolas = new List<Escola> { escolas[0], escolas[1] }
            },
            new Professor
            {
                NomeProf = "Ana Souza",
                EmailProf = "ana@email.com",
                CpfProf = "987.654.321-11",
                QutdeAulas = 15,
                // A Professora Ana leciona apenas no Instituto Saber
                Escolas = new List<Escola> { escolas[2] }
            },
            new Professor
            {
                NomeProf = "Marcos Oliveira",
                EmailProf = "marcos@email.com",
                CpfProf = "456.789.123-22",
                QutdeAulas = 25,
                // O Professor Marcos leciona na Escola Amanhã e no Instituto Saber
                Escolas = new List<Escola> { escolas[1], escolas[2] }
            }
        };

        // 3. Exibindo todos os professores e as suas respectivas escolas
        Console.WriteLine("=== RELATÓRIO DE PROFESSORES E ESCOLAS ===");

        foreach (var prof in professores)
        {
            Console.WriteLine($"\nProfessor(a): {prof.NomeProf} (E-mail: {prof.EmailProf})");
            Console.WriteLine("Leciona nas seguintes escolas:");

            foreach (var esc in prof.Escolas)
            {
                Console.WriteLine($"  -> {esc.NomeEscola} [CNPJ: {esc.CnpjEscola}]");
            }
        }

        // ==========================================
        // EXEMPLOS DE CONSULTAS LINQ
        // ==========================================

        Console.WriteLine("\n=== CONSULTAS COM LINQ ===");

        // 1. Filtrar professores que dão mais de 18 aulas (Where)
        Console.WriteLine("\n--- Professores com mais de 18 aulas ---");
        var profsMuitasAulas = professores.Where(p => p.QutdeAulas > 18).ToList();

        foreach (var p in profsMuitasAulas)
        {
            Console.WriteLine($"- {p.NomeProf} ({p.QutdeAulas} aulas)");
        }

        // 2. Encontrar todos os professores que lecionam na "Escola Estadual Amanhã"
        Console.WriteLine("\n--- Professores que lecionam na Escola Estadual Amanhã ---");
        var profsDaEscolaAmanha = professores
            .Where(p => p.Escolas.Any(e => e.NomeEscola == "Escola Estadual Amanhã"))
            .ToList();

        foreach (var p in profsDaEscolaAmanha)
        {
            Console.WriteLine($"- {p.NomeProf}");
        }

        // 3. Projetar (selecionar) apenas os nomes e e-mails dos professores (Select)
        Console.WriteLine("\n--- Lista simplificada (Apenas Nome e E-mail) ---");
        var listaSimplificada = professores
            .Select(p => new { p.NomeProf, p.EmailProf })
            .ToList();

        foreach (var item in listaSimplificada)
        {
            Console.WriteLine($"> {item.NomeProf} - {item.EmailProf}");
        }

        // 4. Ordenar os professores por quantidade de aulas em ordem decrescente (OrderByDescending)
        Console.WriteLine("\n--- Professores ordenados por quantidade de aulas (Maior para menor) ---");
        var profsOrdenados = professores.OrderByDescending(p => p.QutdeAulas).ToList();

        foreach (var p in profsOrdenados)
        {
            Console.WriteLine($"- {p.NomeProf}: {p.QutdeAulas} aulas");
        }

        // Agrupa os professores por número de aulas
        var professoresPorAulas = professores.GroupBy(p => p.QutdeAulas);

        foreach (var grupo in professoresPorAulas)
        {
            Console.WriteLine($"\nProfessores com {grupo.Key} aulas:");
            foreach (var p in grupo)
            {
                Console.WriteLine($"  - {p.NomeProf}");
            }
        }

        // Quantidade total de professores
        int totalProfessores = professores.Count();

        // Soma de todas as aulas de todos os professores combinadas
        int somaTotalAulas = professores.Sum(p => p.QutdeAulas);

        // Média de aulas por professor
        double mediaAulas = professores.Average(p => p.QutdeAulas);

        Console.WriteLine($"\n--- Estatísticas ---");
        Console.WriteLine($"Total de Professores: {totalProfessores}");
        Console.WriteLine($"Soma de Aulas: {somaTotalAulas}");
        Console.WriteLine($"Média de Aulas: {mediaAulas:F2}");

        Console.WriteLine("\n--- Relacionamento Reverso: Escola e seus Professores ---");

        foreach (var escola in escolas)
        {
            // Usa o LINQ para filtrar quais professores possuem esta escola na sua lista
            var profsDaEscola = professores.Where(p => p.Escolas.Contains(escola)).ToList();

            Console.WriteLine($"\nEscola: {escola.NomeEscola}");
            if (profsDaEscola.Any())
            {
                foreach (var p in profsDaEscola)
                {
                    Console.WriteLine($"  -> Professor(a): {p.NomeProf}");
                }
            }
            else
            {
                Console.WriteLine("  -> Nenhum professor cadastrado nesta escola.");
            }
        }

        // Existe algum professor com mais de 30 aulas?
        bool temProfessorComMuitasAulas = professores.Any(p => p.QutdeAulas > 30);

        // Todos os professores possuem e-mail preenchido?
        bool todosTemEmail = professores.All(p => !string.IsNullOrEmpty(p.EmailProf));

        Console.WriteLine($"\n--- Validações ---");
        Console.WriteLine($"Existe professor com mais de 30 aulas? {temProfessorComMuitasAulas}");
        Console.WriteLine($"Todos os professores têm e-mail? {todosTemEmail}");

        Console.WriteLine("\n--- Paginação (Pulando 1 e pegando os próximos 2) ---");

        // Pula o primeiro professor da lista e pega os 2 seguintes
        var professoresPaginados = professores.Skip(1).Take(2).ToList();

        foreach (var p in professoresPaginados)
        {
            Console.WriteLine($"- {p.NomeProf}");
        }

        var profsSQLStyle = from p in professores
                            where p.QutdeAulas > 18
                            orderby p.NomeProf
                            select p;

        foreach (var professor in profsSQLStyle)
        {
            Console.WriteLine($"Nome: {professor.NomeProf} | Aulas: {professor.QutdeAulas} | E-mail: {professor.EmailProf}");
        }

        // ==========================================
        // MAIS EXEMPLOS AVANÇADOS DE LINQ
        // ==========================================

        // 6. Projeção Avançada (Criando um novo objeto customizado no Select)
        // Em vez de usar um tipo anônimo, podemos projetar os dados estruturando uma nova informação formatada
        Console.WriteLine("\n--- 6. Relatório Compacto Customizado (Select) ---");
        var relatorioCompacto = professores
            .Select(p => new
            {
                Identificacao = p.NomeProf.ToUpper(),
                Contato = p.EmailProf,
                CargaHoraria = p.QutdeAulas * 4 // Exemplo simulando horas mensais
            })
            .ToList();

        foreach (var item in relatorioCompacto)
        {
            Console.WriteLine($"[NOME]: {item.Identificacao} | [EMAIL]: {item.Contato} | [HORAS]: {item.CargaHoraria}h");
        }


        // 7. Busca Segura por Identificador Único (FirstOrDefault / SingleOrDefault)
        // Útil para buscar um registro específico na lista instantaneamente sem quebrar se não achar
        Console.WriteLine("\n--- 7. Busca por CPF específico ---");
        string cpfBusca = "987.654.321-11";
        var professorEncontrado = professores.FirstOrDefault(p => p.CpfProf == cpfBusca);

        if (professorEncontrado != null)
        {
            Console.WriteLine($"Professor localizado: {professorEncontrado.NomeProf} - {professorEncontrado.EmailProf}");
        }
        else
        {
            Console.WriteLine("Nenhum professor encontrado com este CPF.");
        }


        // 8. Selecionando apenas uma propriedade específica transformada (Ex: Apenas uma lista de strings com os e-mails)
        Console.WriteLine("\n--- 8. Lista de E-mails de Contato ---");
        List<string> listaEmails = professores.Select(p => p.EmailProf).ToList();

        foreach (var email in listaEmails)
        {
            Console.WriteLine($"-> {email}");
        }


        // 9. SelectMany (Achatar coleções: Pegando todas as escolas de todos os professores sem repetir)
        Console.WriteLine("\n--- 9. Todas as Escolas Vinculadas (Com Distinct para evitar repetidas) ---");
        var todasAsEscolasUnicas = professores
            .SelectMany(p => p.Escolas)
            .Distinct()
            .ToList();

        foreach (var esc in todasAsEscolasUnicas)
        {
            Console.WriteLine($"- Escola: {esc.NomeEscola}");
        }


        // 10. Max e Min (Encontrando os limites numéricos)
        Console.WriteLine("\n--- 10. Valores Máximos e Mínimos ---");
        int maxAulas = professores.Max(p => p.QutdeAulas);
        int minAulas = professores.Min(p => p.QutdeAulas);

        Console.WriteLine($"A maior quantidade de aulas ministrada é: {maxAulas}");
        Console.WriteLine($"A menor quantidade de aulas ministrada é: {minAulas}");

        // Transforma a lista em um Dicionário onde a chave é o CPF do professor
        var dicionarioProfessores = professores.ToDictionary(p => p.CpfProf);

        // Busca direta e instantânea (O(1) de performance)
        var profEncontrado = dicionarioProfessores["123.456.789-00"];
        Console.WriteLine($"Encontrado via Dicionário: {profEncontrado.NomeProf}");

        var listaGrupoA = new List<Professor> { professores[0], professores[1] };
        var listaGrupoB = new List<Professor> { professores[1], professores[2] };

        // Pega apenas quem está nos dois grupos ao mesmo tempo
        var quemEstaNosDois = listaGrupoA.Intersect(listaGrupoB).ToList();

        // Agrupa os professores por quantidade de aulas e traz apenas os grupos que têm mais de 1 professor
        var gruposComMaisDeUmProfessor = professores
            .GroupBy(p => p.QutdeAulas)
            .Where(grupo => grupo.Count() > 1)
            .ToList();

        foreach (var grupo in gruposComMaisDeUmProfessor)
        {
            Console.WriteLine($"Aulas: {grupo.Key} (Possui {grupo.Count()} professores neste grupo)");
        }

        var consultaJoin = professores
          .Join(
        escolas,                          // Segunda lista a ser cruzada
        prof => prof.QutdeAulas,         // Chave do primeiro (exemplo didático)
        esc => 20,                       // Chave da segunda
        (prof, esc) => new { prof.NomeProf, esc.NomeEscola } // O que vai retornar
         ).ToList();

        foreach(var consulta in consultaJoin)
        {
            Console.WriteLine(consulta);
        }

        var resultadoSkipWhile = professores.SkipWhile(p => p.QutdeAulas <= 15).ToList();

        foreach (var consulta in resultadoSkipWhile)
        {
            // Acessa as propriedades individualmente
            Console.WriteLine($"Nome: {consulta.NomeProf} | Aulas: {consulta.QutdeAulas} | E-mail: {consulta.EmailProf}");
        }

        // Pega os professores do início da lista apenas enquanto a quantidade de aulas for <= 20
        var professoresAte20Aulas = professores.TakeWhile(p => p.QutdeAulas <= 20).ToList();

        foreach (var p in professoresAte20Aulas)
        {
            Console.WriteLine($"Nome: {p.NomeProf} | Aulas: {p.QutdeAulas}");
        }

        // Divide a lista de professores em blocos de até 2 itens por vez
        var lotesDeProfessores = professores.Chunk(2);

        int numeroLote = 1;
        foreach (var lote in lotesDeProfessores)
        {
            Console.WriteLine($"\n--- Lote {numeroLote} ---");
            foreach (var p in lote)
            {
                Console.WriteLine($"- {p.NomeProf}");
            }
            numeroLote++;
        }

        var statusAulas = new List<string> { "Meta Atingida", "Em Desenvolvimento", "Destaque do Mês" };

        // Une a lista de professores com a lista de status baseada na ordem
        var professoresComStatus = professores.Zip(statusAulas, (prof, status) => new {
            Nome = prof.NomeProf,
            Situacao = status
        });

        foreach (var item in professoresComStatus)
        {
            Console.WriteLine($"{item.Nome} -> Status: {item.Situacao}");
        }

        // Soma o total de aulas acumulando os valores de forma personalizada
        int totalAulasAcumuladas = professores.Aggregate(0, (acumulador, prof) => acumulador + prof.QutdeAulas);

        Console.WriteLine($"\n--- Total de Aulas via Aggregate ---");
        Console.WriteLine($"Soma calculada: {totalAulasAcumuladas}");

        // Tenta filtrar um professor com muitas aulas irreais
        var resultadoVazio = professores.Where(p => p.QutdeAulas > 1000).DefaultIfEmpty();

        foreach (var item in resultadoVazio)
        {
            if (item == null)
            {
                Console.WriteLine("\n--- DefaultIfEmpty ---");
                Console.WriteLine("A lista filtrada retornou vazia, nenhum professor atende ao critério.");
            }
        }

        // Exemplo simulando uma lista mista
        var listaMista = new List<object> { "Texto qualquer", 123, professores[0], professores[1] };

        // Pega apenas o que for do tipo Professor
        var apenasProfessores = listaMista.OfType<Professor>().ToList();

        Console.WriteLine($"\n--- OfType (Filtro por Tipo) ---");
        Console.WriteLine($"Encontrados {apenasProfessores.Count} professores na lista mista.");

        var listaA = new List<int> { 1, 2, 3 };
        var listaB = new List<int> { 1, 2, 3 };

        bool saoIguais = listaA.SequenceEqual(listaB);

        Console.WriteLine($"\n--- SequenceEqual ---");
        Console.WriteLine($"As duas listas de números são exatamente iguais? {saoIguais}");

        // Ordena os professores pela quantidade de escolas na lista deles, do maior para o menor, e pega o primeiro
        var professorMaisEscolas = professores
            .OrderByDescending(p => p.Escolas.Count)
            .FirstOrDefault();

        if (professorMaisEscolas != null)
        {
            Console.WriteLine($"\n--- Professor com Mais Escolas ---");
            Console.WriteLine($"{professorMaisEscolas.NomeProf} leciona em {professorMaisEscolas.Escolas.Count} escola(s).");
        }

        Console.WriteLine("\n--- Escolas com mais de 1 professor ---");

        var escolasComMuitosProfessores = escolas.Where(escola =>
            professores.Count(p => p.Escolas.Contains(escola)) > 1
        ).ToList();

        foreach (var esc in escolasComMuitosProfessores)
        {
            Console.WriteLine($"- {esc.NomeEscola}");
        }

        Console.WriteLine("\n--- Relatório Plano (Cruzamento Direto) ---");

        var relatorioPlano = professores
            .SelectMany(p => p.Escolas, (prof, esc) => new {
                NomeProfessor = prof.NomeProf,
                NomeEscola = esc.NomeEscola,
                Cnpj = esc.CnpjEscola
            })
            .ToList();

        foreach (var item in relatorioPlano)
        {
            Console.WriteLine($"[PROF]: {item.NomeProfessor} <---> [ESCOLA]: {item.NomeEscola} ({item.Cnpj})");
        }

        string cnpjAlvo = "98.765.432/0001-12"; // CNPJ da Escola Estadual Amanhã

        bool temProfessorNaEscola = professores.Any(p => p.Escolas.Any(e => e.CnpjEscola == cnpjAlvo));

        Console.WriteLine($"\n--- Validação de Vínculo ---");
        Console.WriteLine($"Existe algum professor alocado na escola com CNPJ {cnpjAlvo}? {temProfessorNaEscola}");

        Console.WriteLine("\n--- Agrupamento: Professores por Escola ---");

        // Cria uma consulta unindo as escolas aos professores correspondentes
        var profsPorEscola = escolas.Select(escola => new {
            Escola = escola.NomeEscola,
            ProfessoresDaEscola = professores.Where(p => p.Escolas.Contains(escola)).ToList()
        });

        foreach (var grupo in profsPorEscola)
        {
            Console.WriteLine($"\nEscola: {grupo.Escola}");
            if (grupo.ProfessoresDaEscola.Any())
            {
                foreach (var p in grupo.ProfessoresDaEscola)
                {
                    Console.WriteLine($"  - {p.NomeProf} ({p.QutdeAulas} aulas)");
                }
            }
            else
            {
                Console.WriteLine("  - Nenhuma alocação encontrada.");
            }
        }

        Console.WriteLine("\n--- Ordenação Múltipla e Paginação ---");

        var professoresPaginadosEOrdenados = professores
            .OrderBy(p => p.NomeProf)                // Primeiro critério: Ordem alfabética do nome
            .ThenByDescending(p => p.QutdeAulas)     // Segundo critério: Maior quantidade de aulas em caso de nomes iguais
            .Skip(0)                                 // Pula os primeiros registros (ex: página 1)
            .Take(2)                                 // Pega apenas 2 registros por página
            .ToList();

        foreach (var p in professoresPaginadosEOrdenados)
        {
            Console.WriteLine($"- {p.NomeProf} | {p.QutdeAulas} aulas");
        }

        Console.WriteLine("\n--- Resumo de Carga de Escolas por Professor ---");

        var resumoCargaEscolas = professores
            .Select(p => new {
                Nome = p.NomeProf,
                TotalEscolas = p.Escolas.Count, // Conta quantas escolas ele possui na lista dele
                TotalAulas = p.QutdeAulas
            })
            .ToList();

        foreach (var item in resumoCargaEscolas)
        {
            Console.WriteLine($"Professor(a): {item.Nome} | Escolas vinculadas: {item.TotalEscolas} | Aulas: {item.TotalAulas}");
        }

        Console.WriteLine("\n--- Validação de Regra de Negócio ---");

        bool todosComMaisDeDezAulasTemEscola = professores
            .Where(p => p.QutdeAulas > 10)
            .All(p => p.Escolas.Any());

        Console.WriteLine($"Todos os professores com mais de 10 aulas possuem pelo menos uma escola vinculada? {todosComMaisDeDezAulasTemEscola}");

        Console.WriteLine("\n--- Consulta Paralela de Alta Performance ---");

        // O AsParallel processa os dados usando múltiplos núcleos da CPU simultaneamente
        var professoresPesadosEmParalelo = professores
            .AsParallel()
            .Where(p => p.QutdeAulas > 10)
            .ToList();

        foreach (var p in professoresPesadosEmParalelo)
        {
            Console.WriteLine($"- {p.NomeProf} (Processado em paralelo)");
        }

        Console.WriteLine("\n--- Criando um Lookup (Dicionário com chaves múltiplas) ---");

        // Cria um índice rápido onde a chave é a quantidade de aulas, agrupando os professores correspondentes
        var lookupPorAulas = professores.ToLookup(p => p.QutdeAulas);

        // Busca instantânea por um grupo específico (ex: quem tem 20 aulas)
        foreach (var prof in lookupPorAulas[20])
        {
            Console.WriteLine($"Professor com exatas 20 aulas: {prof.NomeProf}");
        }

        Console.WriteLine("\n--- Concatenação Simples de Listas ---");

        var listaExtraProfessores = new List<Professor>
{
    new Professor { NomeProf = "Juliana Lima", QutdeAulas = 12 }
};

        // Junta a lista principal com a lista extra
        var todasAsListasJuntas = professores.Concat(listaExtraProfessores).ToList();

        Console.WriteLine($"Total de professores após o Concat: {todasAsListasJuntas.Count}");

        Console.WriteLine("\n--- Exemplo de Except (Professores fora do grupo de destaque) ---");

        var professoresDestaque = new List<Professor> { professores[0] }; // Apenas o Carlos Silva

        // Pega todos os professores, exceto os que estão na lista de destaque
        var professoresComuns = professores.Except(professoresDestaque).ToList();

        foreach (var p in professoresComuns)
        {
            Console.WriteLine($"- Professor comum: {p.NomeProf}");
        }

        Console.WriteLine("\n--- Exemplo de Chunk (Dividindo em lotes de 2) ---");

        Console.WriteLine("\n--- Exemplo de Cast (Conversão forçada de tipo) ---");

        // Simulando uma lista antiga não tipada de objetos
        System.Collections.ArrayList listaAntiga = new System.Collections.ArrayList();
        listaAntiga.Add(professores[0]);
        listaAntiga.Add(professores[1]);

        // Converte a lista antiga para IEnumerable<Professor> para poder filtrar
        var professoresConvertidos = listaAntiga.Cast<Professor>().Where(p => p.QutdeAulas > 15).ToList();

        foreach (var p in professoresConvertidos)
        {
            Console.WriteLine($"- Professor convertido: {p.NomeProf}");
        }

        Console.WriteLine("\n--- Relatório utilizando CodigoAudit ---");

        // 1. Supondo que você tenha uma lista de códigos de auditoria correspondentes aos professores
        var codigosAudit = new List<string> { "AUD-1001", "AUD-1002", "AUD-1003" };

        // 2. Usando o Zip para unir a lista de professores com os códigos
        var relatorioAuditoria = professores.Zip(codigosAudit, (prof, codigo) => new {
            NomeProfessor = prof.NomeProf,
            // Atribuindo o código à propriedade CodigoAudit do seu objeto anônimo (ou da sua classe)
            CodigoAudit = codigo,
            TotalAulas = prof.QutdeAulas
        });

        // 3. Exibindo o resultado no console
        foreach (var item in relatorioAuditoria)
        {
            Console.WriteLine($"[Código: {item.CodigoAudit}] Professor(a): {item.NomeProfessor} | Aulas: {item.TotalAulas}");
        }

        Console.WriteLine("\n--- Concatenação de Textos com Aggregate ---");

        string todosOsNomes = professores
            .Select(p => p.NomeProf)
            .Aggregate((acumulador, proximo) => $"{acumulador}, {proximo}");

        Console.WriteLine($"Professores na lista: {todosOsNomes}");

        string ordenarPor = "aulas"; // Pode vir de uma escolha do usuário

        Console.WriteLine($"\n--- Ordenação Dinâmica (Critério: {ordenarPor}) ---");

        var consultaDinamica = ordenarPor == "nome"
            ? professores.OrderBy(p => p.NomeProf).ToList()
            : professores.OrderByDescending(p => p.QutdeAulas).ToList();

        foreach (var p in consultaDinamica)
        {
            Console.WriteLine($"- {p.NomeProf} ({p.QutdeAulas} aulas)");
        }
    }
}