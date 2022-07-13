double CoordinateX (double num1, double num2, double num3, double num4) 
// где num1 = k1, num2 = b1, num3 = k2, num4 = b2
{
    // y = k1x + b1, y = k2x + b2
    // k1x + b1 - k2x - b2 = y - y = 0
    // x = (b2 - b1) / (k1 - k2)
    double coordinate1 = (num4 - num2) / (num1 - num3); 
    return coordinate1;
}

double CoordinateY (double num5, double num6, double resultMethodCoordinateX)
// где num5 = k2, num6 = b2, numFromFirstMethod = координата x, полученная при помощи метода CoordinateX
// y = k2x + b2
{
    double coordinate2 = num5 * resultMethodCoordinateX + num6;
    return coordinate2;
}

Console.Write ("Введите значение точки k1: ");
double k1 = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите значение точки b1: ");
double b1 = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите значение точки k2: ");
double k2 = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите значение точки b2: ");
double b2 = Convert.ToDouble (Console.ReadLine ());

double x = CoordinateX (k1, b1, k2, b2);
double y = CoordinateY (k2, b2, x);
Console.Write ($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");