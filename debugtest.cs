class Program
{
    public static void Main()
    {
        string s = "";
        for (int i = 5; i <= 10; i += 2)
            s += i + " ";

        for (int i = 10; i >= 3; i--)
            if (i % 2 == 0)
                s += i + " ";

        s = "";
        for (int i = 7; i <= 14; i += 3)
            s += i + " ";
        s += "!";

        int sum = 0;
        for (int apple = 1; apple <= 3;)
            sum = sum + apple++;
    }
}