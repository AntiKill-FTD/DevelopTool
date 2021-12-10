using Microsoft.Extensions.DependencyInjection;
using Tool.IService.Test;
using Tool.Test;

public class Program
{
    public static void Main(string[] args)
    {
        ServiceProvider serviceProvider = StartUp.Configuration();

        IBlogService bs = serviceProvider.GetService<IBlogService>();

        bs.InsertPost();

        //等待输入
        Console.ReadLine();
    }


}