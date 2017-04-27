namespace Zadania
{
    public static class RozszerzenieInt
    {
        public static int Silnia(this int x)
        {
            if (x ==1)
            {
                return 1;
            }
            else
            {
                return x*Silnia(x - 1);
            }
        }
    }
}