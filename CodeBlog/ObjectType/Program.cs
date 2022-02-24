int x = 1;
int y = 1;

Console.WriteLine(x.Equals(y));

object obj1 = x;
object obj2 = y;

Console.WriteLine(obj1.Equals(obj2));

Point p1 = new() { X = 1 };
Point p2 = new() { X = 1 };

Console.WriteLine(p1.Equals(p2));
Console.WriteLine(null == null);

Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());

Console.WriteLine(object.Equals(p1, p2));
Console.WriteLine(object.Equals(x, y));
Console.WriteLine(object.Equals(obj1, obj2));

Console.WriteLine(object.ReferenceEquals(p1, p2));
Console.WriteLine(object.ReferenceEquals(x, y));
Console.WriteLine(object.ReferenceEquals(obj1, obj2));
Console.WriteLine(object.ReferenceEquals(p1, p1));

Point p3 = p1.Copy();

Console.WriteLine(object.Equals(p1, p3));
Console.WriteLine((object.ReferenceEquals(p1, p2)));

Console.WriteLine(p1);


class Point
{
    public int X { get; set; }

    public override bool Equals(object? obj)
    {
        // Equals не должен выкидывать исключение!
        if (obj == null) return false;

        if (obj is Point point)
        {
            return this.X.Equals(point.X);
        }
        else
        {
            return false;
        }
    }

    public override int GetHashCode()
    {
        return X;
    }

    public override string ToString()
    {
        return $"{X}";
    }

    public Point Copy()
    {
        return (Point)this.MemberwiseClone();
    }
}