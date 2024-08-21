// See https://aka.ms/new-console-template for more information

using DependencyInjectionNET6;
using DependencyInjectionNET6.Interface;
using DependencyInjectionNET6.Tasitlar;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

class Program
{
    static void Main()
    {
        //Kullanacağımız sınıfların örneğini oluşturmak için IHostBuilder nesnemizi oluşturuyoruz. Bu Ninject kullanımındaki çekirdeğin oluşturulması işlemi ile aynı.
        var builder = Host.CreateDefaultBuilder();

        //ConfigureServices yöntemi ile kullanacağımız nesneleri oluşturuyoruz.
        //Aşağıda ITasit bağlanıyor ve ITasit nesnesi kullanıldığında bunun türünün Otobus olduğu belirtiliyor.
        builder.ConfigureServices(services => services.AddScoped<ITasit, Motorsiklet>());

        //Tasit nesnesinin örneği oluşturuluyor.
        builder.ConfigureServices(services => services.AddSingleton<Tasit>());

        //Uygulamamızı başlatmadan önceki işlemlerin yapılmasını sağlıyoruz.
        var app = builder.Build();

        //Uygulamamızdaki Tasit sınıfındaki Kullan metodunu çağırıyoruz ve uygulamamızı başlatmış oluyoruz.
        app.Services.GetService<Tasit>().Kullan();

    }
}

