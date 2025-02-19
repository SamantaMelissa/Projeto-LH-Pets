namespace Projeto_LH_Pets___T01;

public class Program
{
    //Método Principal
    public static void Main(string[] args)
    {
        //Criando um novo aplicativo:
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto WEB - LH Pets versão 1");

        //habilitar o uso de telas estáticas
        app.UseStaticFiles();

        //Definir uma rota para quando a url tiver /index
        app.MapGet("/home", (HttpContext contexto) => {
            contexto.Response.Redirect("index.html", false);
        });

        app.Run();
    }
}
