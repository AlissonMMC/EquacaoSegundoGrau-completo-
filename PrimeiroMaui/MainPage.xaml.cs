namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_n1.Text);
            double b = Convert.ToDouble(txt_n2.Text);
            double c = Convert.ToDouble(txt_n3.Text);

            double delta = (b * b) - (4 * a * c);

            double x1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            double x2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a); ;

            string msg = $"O resultado é {x1} e {x2}";

            

            if (delta < 0)
            {

                DisplayAlert("Resultado", msg, "Fechar");
            }
            else
            {
                DisplayAlert("Maui", msg, "Fechar");
            }
        }
    }

}
