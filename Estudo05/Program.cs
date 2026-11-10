using Estudo05.Entidade;

namespace Estudo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empresa> listaEmpresas = new List<Empresa>() { 
                new Empresa("IBM","34344343",2009, 3400),
                new Empresa("Solutic","433434345",2023, 1200),
                new Empresa("Petrobras","454355667",2009, 8400),
                new Empresa("Solutis","865656575",1982, 4400),
                new Empresa("Target","54455676",2003, 1400),
                new Empresa("Qintess","85745633",2022, 1400),
                new Empresa("Extractta","8757644",2009, 1200),
                new Empresa("Helabs","7657687987",2010, 4),
                new Empresa("Papelaria","9876766565",2010, 4),
                new Empresa("Stone","897764545",1987, 120000),
                new Empresa("Arecipe","0877654565",1999, 213),
                new Empresa("Casa sau de sao jose","y6567767676",1678, 300000),
                new Empresa("Capgemini","9878758787",191, 3400),
                new Empresa("TEES","1324565665",1980, 500),
                new Empresa("Sonda","9876545643",1974, 670000),
            };

            listaEmpresas.Add(new Empresa("Vale do Rio Doce", "4t656768765", 1980, 230000));

            foreach(var item in listaEmpresas)
            {
                Console.WriteLine(item);
            }

        }
    }
}
