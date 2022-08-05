Console.Clear(); //очищаем окно терминала

int xa = 40, ya = 1, //задаем вершины треугольника и отрисовываем его символом +
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = ya; //пусть первая случайная вершина равна вершине а
int count = 0;

while(count < 10000) //тестами определили количество циклов
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2 генер случ число для опред случ вершины
    if (what == 0)
    {
        x = (x + xa)/2; //исходя из координат случ вершины + точка с коорд (х, у)
        y = (y + ya)/2; //вычисляем координаты середины отрезка
    }
    else
    {
        if (what == 1)
        {
            x = (x + xb)/2;
            y = (y + yb)/2;
        }
        else
        {
            x = (x + xc)/2;
            y = (y + yc)/2;
        }
    }

    Console.SetCursorPosition(x, y); //ставим + в коорд середины отрезка этой итерации
    Console.WriteLine("+");
    count = count + 1;
}