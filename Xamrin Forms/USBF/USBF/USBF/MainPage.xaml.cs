using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http;
using Xamarin.Forms;

namespace USBF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{

            ApiAsync();
            InitializeComponent();
        }


        public async void ApiAsync() {
            var apiclinete = new HttpClient();
            var response = await apiclinete.GetStringAsync("https://s3.amazonaws.com/dolartoday/data.json");
            var resultado = JsonConvert.DeserializeObject<USBF.Moldes.Example>(response);
            DolarParalelo.Text = resultado.USD.dolartoday.ToString("N", CultureInfo.CreateSpecificCulture("es-VE"));
        }

        public void Bt_Calcular(object sender, System.EventArgs e) {
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("es-VE");
            double oDolarParalelo, oMontoDescuento, oDolares;

            double.TryParse(DolarParalelo.Text, style, culture, out oDolarParalelo);
            double.TryParse(MontoDescuento.Text, style, culture, out oMontoDescuento);
            double.TryParse(Dolares.Text, style, culture, out oDolares);
            MontoTotal.Text = string.Format(culture, "{0:N2}", (oDolarParalelo - oMontoDescuento) * oDolares);

        }
    }
}
