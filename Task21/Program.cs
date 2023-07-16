// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//AB = корень из (х2-х1)2 + (у2-у1)2
// а это формула С#:
//Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2));

void ShowQuarter(int ax, int ay, int az, int bx, int by, int bz) 
{
    double distance = Math.Sqrt(Math.Pow(ax-bx, 2)+Math.Pow(ay-by, 2)+Math.Pow(az-bz, 2));
    Console.Write($"Расстояние между двух точек: {distance}");
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
} 
int ax  = GetInput("Введите координату x точки А: "); 
int ay  = GetInput("Введите координату y точки А: ");
int az  = GetInput("Введите координату z точки a: "); 
int bx  = GetInput("Введите координату x точки b: ");
int by  = GetInput("Введите координату y точки b: "); 
int bz  = GetInput("Введите координату z точки b: ");
ShowQuarter(ax, ay, az, bx, by, bz);
