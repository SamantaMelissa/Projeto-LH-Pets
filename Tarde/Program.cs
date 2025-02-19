namespace Tarde;
public class Program
{
    //Método principal 
    public static void Main(string[] args)
    {
        //Responsáveis por criar um app com telas estáticas
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        //Define uma rota caso esteja sem informações após a /, na url
        app.MapGet("/", () => "Projeto WEB - LH Pets");

        //Permite a utilização de telas estáticas
        app.UseStaticFiles();

        //Quando o usuário escrever na url /menu será redirecionado ao arquivo index.html
        app.MapGet("/menu", (HttpContext contexto) => {
            contexto.Response.Redirect("index.html", false);
        });

        app.Run();
    }
}