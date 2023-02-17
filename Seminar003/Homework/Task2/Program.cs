// See https://aka.ms/new-console-template for more information
double[] pointA = new double[3];
Console.WriteLine("x(A): ");
pointA[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y(A): ");
pointA[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z(A): ");
pointA[2] = Convert.ToDouble(Console.ReadLine());

double[] pointB = new double[3];
Console.WriteLine("x(B): ");
pointB[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("y(B): ");
pointB[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("z(B): ");
pointB[2] = Convert.ToDouble(Console.ReadLine());

double ABx = pointB[0] - pointA[0];
double ABy = pointB[1] - pointA[1];
double ABz = pointB[2] - pointA[2];

double distance = Math.Sqrt(Math.Pow(ABx, 2) + Math.Pow(ABy, 2) + Math.Pow(ABz, 2));
Console.WriteLine(distance);

