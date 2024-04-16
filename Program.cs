using ListaDeAdjacencia;

Grafo grafo = new Grafo();

grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();
grafo.AdicionarVertice();

grafo.AdicionarAresta(0, 1);
grafo.AdicionarAresta(0, 6);
grafo.AdicionarAresta(0, 8);
grafo.AdicionarAresta(1, 0);
grafo.AdicionarAresta(1, 4);
grafo.AdicionarAresta(1, 9);
grafo.AdicionarAresta(2, 4);
grafo.AdicionarAresta(2, 6);
grafo.AdicionarAresta(3, 4);
grafo.AdicionarAresta(3, 5);
grafo.AdicionarAresta(3, 8);
grafo.AdicionarAresta(4, 1);
grafo.AdicionarAresta(4, 2);
grafo.AdicionarAresta(4, 3);
grafo.AdicionarAresta(4, 5);
grafo.AdicionarAresta(4, 9);
grafo.AdicionarAresta(5, 3);
grafo.AdicionarAresta(5, 4);
grafo.AdicionarAresta(6, 0);
grafo.AdicionarAresta(6, 2);
grafo.AdicionarAresta(7, 9);
grafo.AdicionarAresta(7, 8);
grafo.AdicionarAresta(8, 0);
grafo.AdicionarAresta(8, 3);
grafo.AdicionarAresta(8, 7);
grafo.AdicionarAresta(9, 1);
grafo.AdicionarAresta(9, 4);
grafo.AdicionarAresta(9, 7);

grafo.GrauMaximoVertice();

grafo.MostraLista();