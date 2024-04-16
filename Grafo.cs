using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDeAdjacencia
{
    public class Grafo
    {
        private List<List<int>> vertices;
        public Grafo()
        {
            vertices = new List<List<int>>();
        }

        public void AdicionarVertice()
        {
            List<int> vertice = new List<int>();
            vertices.Add(vertice);

            for (int i = 0; i < vertices.Count; i++)
            {
                List<int> oldVertice = vertices[i];
                while (oldVertice.Count < vertices.Count)
                {
                    oldVertice.Add(0);
                }
                vertices[i] = oldVertice;
            }
        }

        public void AdicionarAresta(int origem, int destino)
        {

            if (vertices.Count < origem || vertices.Count < destino)
            {
                throw new Exception("Vertice não existe.");
            }

            vertices[origem][destino] += 1;
        }

        public void GrauMaximoVertice()
        {
            Console.WriteLine("Grau de cada vertice:");
            for (int i = 0; i < vertices.Count; i++)
            {
                Console.WriteLine($"Vertice {i} tem grau {vertices[i].Sum()}");
            }
            Console.WriteLine();
        }

        public void MostraLista()
        {
            Console.WriteLine("Lista de adjacencia:");
            for (int i = 0; i < vertices.Count; i++)
            {
                Console.Write($"Vertice {i}: ");
                for (int j = 0; j < vertices[i].Count; j++)
                {

                    Console.Write($"{vertices[i][j]} ");

                }
                Console.WriteLine();
            }
        }

    }
}