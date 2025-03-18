using System;
public class pemrosesData()
{
    public static void dapatkanNilaiTerbesar<xT, yT, zT>(xT input1, yT input2, zT input3)
    {
        dynamic nilaiTerbesar = 0;

        for (int i = 0; i < 3; i++)
        {
            if (nilaiTerbesar < input1)
            {
                nilaiTerbesar = input1;
            }
            else if (nilaiTerbesar < input2)
            {
                nilaiTerbesar = input2;
            }
            else if (nilaiTerbesar < input3)
            {
                nilaiTerbesar = input3;
            }
        }

        Console.WriteLine(nilaiTerbesar);
    }

    static void Main(string[] args)
    {
        long hasil;
        dapatkanNilaiTerbesar<long, long, long>(10, 30, 22);

    }
}