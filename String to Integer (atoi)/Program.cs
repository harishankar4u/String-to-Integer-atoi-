class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MyAtoi("42"));        // 42
        Console.WriteLine(MyAtoi("   -042"));   // -42
        Console.WriteLine(MyAtoi("1337c0d3"));  // 1337
        Console.WriteLine(MyAtoi("0-1"));       // 0
        Console.WriteLine(MyAtoi("words 987")); // 0
    }
    public static int MyAtoi(string str)
    {
        //checking empty string
        if(string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int i= 0; int n=str.Length;

        //skip leading  whitespace
        while (i < n && str[i]==' ')
            i++;

        if (i == n)
        {
            return 0;
        }

        //Check for sign
        int sign = 1;
        if (str[i] == '+' || str[i]=='-')
        {
            sign = (str[i] == '-') ? -1 : 1;
            i++;
        }

        //Convert digits
        long num = 0;
        while(i<n && char.IsDigit(str[i]))
        {
            num=num*10 + (str[i]-'0');

            if (sign == 1 && num>int.MaxValue) return int.MaxValue;
            if(sign==-1 && num<int.MinValue) return int.MinValue;
            i++;
        }
        return (int)(sign * num);

    }
}