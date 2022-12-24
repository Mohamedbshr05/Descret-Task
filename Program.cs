using System;
class project 
{
    static public void Main()
    {
        int a, b, i, j, flag;

        Console.Write("Enter a number please: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second  number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Prime numbers between " + a + " and " + b + " are: ");
        if (a == 1)
        {
            Console.Write(a + " ");
            a++;
            if (b >= 2)
            {
                Console.Write(a + " ");
                a++;
            }
        }
        if (a == 2)
        {
            Console.Write(a + " ");
        }
        if (a % 2 == 0)
        {
            a++;
        }
        for (i = a; i <= b; i = i + 2)
        {
            flag = 1;
            for (j = 2; j * j <= i; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.Write(i + " ");
            }
            //iam mohamed bashiir mohamed section 18 group 3//
        }
    }
}