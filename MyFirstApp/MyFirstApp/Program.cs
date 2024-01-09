namespace MyFirstApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /* CreateBuilder: cria uma instância de aplicativo da web (builder)
             * contém a configuração do ambiente e serviço padrão
             */
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build(); // é uma referência ao aplicativo web.
            
            // Adiciona uma rota na aplicação com um parâmetro especifico,
            // Quando receber uma requisição, será retornado o texto.
            app.MapGet("/", () => "Hello World!");
            

            // Inicia a aplicação.
            app.Run();
        }
    }
}
