namespace DemoMVVMAprendiz.Vista
{
    using DemoMVVMAprendiz.Modelo;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleAprendiz : ContentPage
	{
        public DetalleAprendiz(Aprendiz aprendizSeleccionado)
        {
            InitializeComponent();
            this.BindingContext = aprendizSeleccionado;
		}
	}
}