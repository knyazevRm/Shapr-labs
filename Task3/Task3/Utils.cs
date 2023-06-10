namespace Task3;

public class Utils
{
    public static long Gcd(long a, long b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }

        return a;
    }
}