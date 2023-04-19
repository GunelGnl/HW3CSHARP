//Task19
System.Console.WriteLine("Add five digit number");
int number = int.Parse(System.Console.ReadLine());
int[] digits = new int[5];
int index = 0;
while (number > 0)
{
    digits[index] = number % 10;
    number /= 10;
    index++;
}
bool Palindrome = true;
for ( int i =0; i< digits.Length / 2; i++)
if (digits[i] != digits [digits.Length - i -1])
{
Palindrome = false;
break;    
}
if (Palindrome)
{
    System.Console.WriteLine("Digit is Palindrome");
    } else
    {
        System.Console.WriteLine("Digit is not Palindrome");
    }

    //Task21

    System.Console.WriteLine("Add Coordinates");
int x1 = Coordinate ("a", "A");
int y1 = Coordinate ("b", "A");
int z1 = Coordinate ("c", "A");
int x2 = Coordinate ("a1", "B");
int y2 = Coordinate ("b1", "B");
int z2 = Coordinate ("c1", "B");
int Coordinate (string CoordinateName, string PointName)
{
    System.Console.WriteLine($"Add Coodinate {CoordinateName} points {PointName}: "); 
    return int.Parse (Console.ReadLine());
    }
Double Decision(double x1,double x2, double y1, double y2, double z1, double z2){
    return Math.Sqrt(Math.Pow((x2-x1), 2) +
    Math.Pow((y2-y1), 2) +
    Math.Pow((z2-z1), 2));
}
double SegmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Segment Lenght { SegmentLength}");

//Task 23

Console.Write("Add digit N: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Cubic table from 1 to " + n + ":");
    for (int i = 1; i <= n; i++) {
      Console.WriteLine(i + "^3 = " + Math.Pow(i, 3));
    }


