using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string text = "Hello FileStream";

        FileStream fs =
            new FileStream("sample.txt",
            FileMode.Create);

        byte[] data = Encoding.UTF8.GetBytes(text);

        fs.Write(data, 0, data.Length);
        fs.Close();

        MemoryStream ms = new MemoryStream(data);

        Console.WriteLine(
            Encoding.UTF8.GetString(ms.ToArray())
        );
    }
}