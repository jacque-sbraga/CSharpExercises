namespace MyFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* CreateBuilder: cria uma inst�ncia de aplicativo da web (builder)
             * cont�m a configura��o do ambiente e servi�o padr�o
             */
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build(); // � uma refer�ncia ao aplicativo web.
            
            // Adiciona uma rota na aplica��o com um par�metro especifico,
            // Quando receber uma requisi��o, ser� retornado o texto.
            app.MapGet("/", () => "Hello World!");
            

            // Inicia a aplica��o.
            app.Run();
        }
    }
}
