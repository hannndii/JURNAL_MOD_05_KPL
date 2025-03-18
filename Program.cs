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

        SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();

        simpleDataBase.addNewData(10);
        simpleDataBase.addNewData(30);
        simpleDataBase.addNewData(22);
        simpleDataBase.PrintAllData();
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]} yang disimpan pada waktu UTC {inputDates[i]}");
        }
    }

}