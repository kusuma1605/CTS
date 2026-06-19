using System;
using System.Threading.Tasks;

class Program
{
    static async Task UploadFileAsync()
    {
        Console.WriteLine("Uploading file...");

        await Task.Delay(3000);

        Console.WriteLine("File uploaded successfully.");
    }

    static async Task Main()
    {
        await UploadFileAsync();
    }
}