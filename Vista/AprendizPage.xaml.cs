namespace DemoMVVMAprendiz.Vista
{
   using Xamarin.Forms;
   using Vista;
   using Modelo;
   using VistaModelo;

    
	public partial class AprendizPage : ContentPage
	{
		public AprendizPage ()
		{
			InitializeComponent ();
            this.BindingContext = new AprendizViewModel();
            lstName.ItemSelected += LstName_ItemSelected;
		}

        private void LstName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var aprendizSeleccionado = (Aprendiz)e.SelectedItem;
            if (aprendizSeleccionado==null)
            {
                return;
            }
            Navigation.PushAsync(new DetalleAprendiz(aprendizSeleccionado));
            lstName.SelectedItem = null;
        }
    }
}