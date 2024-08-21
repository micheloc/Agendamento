using Agendamento.UI;
using Unity;

static class Program
{
    // O contêiner Unity que será usado para injeção de dependência
    public static IUnityContainer Container { get; private set; }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Configurar o Unity
        Container = UnityConfig.RegisterComponents();

        // Resolver o formulário principal e iniciar a aplicação
        var mainForm = Container.Resolve<TelaPrincipal>();
        Application.Run(mainForm);
    }
}
