using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        // calculate the distance of the point from the center (0,0) using the distance formula  distance = sqrt(x^2 + y^2)

        double distance = Math.Sqrt(x * x + y * y);

        if (distance <= 1) return 10; 
        if (distance <= 5) return 5;
        if (distance <= 10) return 1;
        return 0;
    }
}
