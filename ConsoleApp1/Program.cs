int x_A, y_A, x_B, y_B, x_C, y_C, count = 0;
double p = 0, AB = 0, BC = 0, CA = 0;

//input coordinate
Console.WriteLine("Enter the coordinate X of A:");
x_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y of A:");
y_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinate X of B:");
x_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y of B:");
y_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinate X of C:");
x_C = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinate Y of C:");
y_C = Convert.ToInt32(Console.ReadLine());

//find the lenght
AB = Math.Sqrt(Math.Pow(x_B - x_A, 2) + Math.Pow(y_B - y_A, 2));
BC = Math.Sqrt(Math.Pow(x_C - x_B, 2) + Math.Pow(y_C - y_B, 2));
CA = Math.Sqrt(Math.Pow(x_A - x_C, 2) + Math.Pow(y_A - y_C, 2));
//output results
Console.WriteLine("Lenght of AB is: " + Convert.ToString(AB) + ".");
Console.WriteLine("Lenght of BC is: " + Convert.ToString(BC) + ".");
Console.WriteLine("Lenght of CA is: " + Convert.ToString(CA) + ".");

//is it equilateral
if (AB == BC && BC == CA)
    Console.WriteLine("The triangle is equilateral.");
else Console.WriteLine("The triangle is NOT equilateral.");

//is it isosceles
if (AB == BC || BC == CA || AB == CA)
    Console.WriteLine("The triangle is isosceles.");
else Console.WriteLine("The triangle is NOT isosceles.");

//is it right
if ((AB * AB + BC * BC == CA * CA) || (AB * AB + CA * CA == BC * BC) || (CA * CA + BC * BC == AB * AB))
    Console.WriteLine("The triangle is right.");
else Console.WriteLine("The triangle is NOT right. (according to the Pythagorean theorem)");

//find the perimeter
p += Math.Pow(Math.Pow(x_A - x_B, 2) + Math.Pow(y_A - y_B, 2), 0.5);
p += Math.Pow(Math.Pow(x_B - x_C, 2) + Math.Pow(y_B - y_C, 2), 0.5);
p += Math.Pow(Math.Pow(x_C - x_A, 2) + Math.Pow(y_C - y_A, 2), 0.5);
//output results
Console.WriteLine("Perimeter = " + Convert.ToString(p) + ".");

//even numbers from 0 to value of triangle perimeter
Console.WriteLine("Even numbers from 0 to value of triangle perimeter.");
do
{    
    Console.WriteLine(Convert.ToString(count));
    count += 2;
} while (count < p);