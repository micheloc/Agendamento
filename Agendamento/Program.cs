using Agendamento.UI;
using Unity;

static class Program
{
    // O cont�iner Unity que ser� usado para inje��o de depend�ncia
    public static IUnityContainer Container { get; private set; }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Configurar o Unity
        Container = UnityConfig.RegisterComponents();

        // Resolver o formul�rio principal e iniciar a aplica��o
        var mainForm = Container.Resolve<TelaPrincipal>();
        Application.Run(mainForm);
    }
}
