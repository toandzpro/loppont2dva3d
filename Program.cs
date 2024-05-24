using System;

public class Point2D
{
    public float x;
    public float y;

    public Point2D()
    {
        x = 0.0f;
        y = 0.0f;
    }

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float X
    {
        get { return x; }
        set { x = value; }
    }

    public float Y
    {
        get { return y; }
        set { y = value; }
    }

    public override string ToString()
    {
        return $"Point2D: ({x}, {y})";
    }
    public static void Main1()
    {
        Point2D point = new Point2D(3.0f, 4.0f);
        Console.WriteLine(point.ToString());
    }
}
public class Point3D : Point2D
{
    public float z;

    public Point3D() : base()
    {
        z = 0.0f;
    }

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public float Z
    {
        get { return z; }
        set { z = value; }
    }

    public override string ToString()
    {
        return $"Point3D: ({X}, {Y}, {z})";
    }
    public static void Main()
    {
        Main1();
        Point3D point = new Point3D(3.0f, 4.0f, 5.0f);
        Console.WriteLine(point.ToString());
    }
}

