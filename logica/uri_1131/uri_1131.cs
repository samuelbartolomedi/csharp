using System;

namespace uri_1131
{
    class uri_1131
    {
        static void Main(string[] args)
        {
            int VitoriasInter = 0;
            int VitoriasGremio = 0;
            int empates = 0;
            int NovoGrenal = 1;

            while( NovoGrenal == 1)
            {
                string[] gols = Console.ReadLine().Split(' ');
                int GolsInter = int.Parse(gols[0]);
                int GolsGremio = int.Parse(gols[1]);

                if (GolsInter > GolsGremio)
                {
                    VitoriasInter = VitoriasInter + 1;
                }
                else if (GolsGremio > GolsInter)
                {
                    VitoriasGremio = VitoriasGremio + 1;
                }
                else
                {
                    empates = empates + 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                NovoGrenal = int.Parse(Console.ReadLine());
            }
            int total = VitoriasGremio + VitoriasInter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter: " + VitoriasInter);
            Console.WriteLine("Gremio: " + VitoriasGremio);
            Console.WriteLine("Empates: " + empates);

            if (VitoriasGremio > VitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (VitoriasInter > VitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
