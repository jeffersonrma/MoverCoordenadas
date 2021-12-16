
using MoverCoordenadas.Model;


//teste 1
Console.WriteLine("Teste 1");
Coordenadas _coordenadas = new Coordenadas(8, 12);
Console.WriteLine(_coordenadas.getCoordenadas);

_coordenadas.Mover(Direcao.Norte, 23);
_coordenadas.Mover(Direcao.Oeste, 7);
_coordenadas.Mover(Direcao.Sul, 40);
_coordenadas.Mover(Direcao.Leste, 33);
_coordenadas.Mover(Direcao.Norte, 15);

_coordenadas.LogCoordenadas.ForEach(
        x => Console.WriteLine(x.getCoordenadas)
);

Console.WriteLine();
Console.WriteLine();


//teste 2
Console.WriteLine("Teste 2");
Coordenadas _coordenadas2 = new Coordenadas(-10, 0);
Console.WriteLine(_coordenadas2.getCoordenadas);

_coordenadas2.Mover(Direcao.Leste, 14);
_coordenadas2.Mover(Direcao.Norte, 27);
_coordenadas2.Mover(Direcao.Oeste, 33);
_coordenadas2.Mover(Direcao.Sul, 20);
_coordenadas2.Mover(Direcao.Leste, 15);

_coordenadas2.LogCoordenadas.ForEach(
        x => Console.WriteLine(x.getCoordenadas)
);



Console.Read();