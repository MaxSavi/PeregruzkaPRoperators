class MyPoints
{
    public int x, y, z;
    public bool boolX, boolY, boolZ;
    public MyPoints(int x = 0, int y = 0, int z = 0, bool boolX = false, bool boolY = true, bool boolZ=true)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.boolX = boolX;
        this.boolY = boolY;
        this.boolZ = boolZ;
    }
    public static MyPoints operator ==(MyPoints obj1, MyPoints obj2)
    {
        MyPoints point = new MyPoints();
        point.boolX = obj1.x == obj2.x;
        point.boolY = obj1.y == obj2.y;
        point.boolZ = obj1.z == obj2.z;
        return point;
    }
    public static MyPoints operator !=(MyPoints obj1, MyPoints obj2)
    {
        MyPoints point = new MyPoints();
        point.boolX = obj1.x != obj2.x;
        point.boolY = obj1.y != obj2.y;
        point.boolZ = obj1.z != obj2.z;
        return point;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyPoints Point1 = new MyPoints(1, 2, 3);
        MyPoints Point2 = new MyPoints(3, 2, 1);
        Console.WriteLine($"Координаты 1 точки: {Point1.x}, {Point1.y}, {Point1.z}");
        Console.WriteLine($"Координаты 2 точки: {Point2.x}, {Point2.y}, {Point2.z}");

        MyPoints Point3 = Point1 == Point2;
        Console.WriteLine($"{ Point3.y}", Point3.boolY);
        Console.WriteLine($"\nPoint1 == Point2: {Point3.boolX}, {Point3.boolY}, {Point3.boolZ}");
        Point3 = Point1 != Point2;
        Console.WriteLine($"\nPoint1 != Point2: {Point3.boolX}, {Point3.boolY}, {Point3.boolZ}");
        Console.ReadLine();
    }
}