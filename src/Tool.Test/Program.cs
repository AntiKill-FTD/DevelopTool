using Tool.Data.Model;
using Tool.Test;

public class Program
{
    public static void Main(string[] args)
    {
        IServiceProvider serviceProvider = StartUp.Configuration();
        BloggingContext bc = (BloggingContext)serviceProvider.GetService(typeof(BloggingContext));
        BlogService bs = new BlogService(bc);
        bs.BlogAct();
        //等待输入
        Console.ReadLine();
    }


}