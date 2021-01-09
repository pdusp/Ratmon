using IO.Swagger.Model;
using Pd.Ratmon;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ViewChanel.xaml
    /// </summary>
    public partial class ViewChanel : Window
    {
        public int id;
        public GetToken token;
        public List<AllCircuitsView> allcircut;
        public ViewChanel(int _id)
        {
            InitializeComponent();
            id = _id;
            txtChanel.Text = id.ToString();
        }

        public async void GetChanel(int id)
        {
            try
            {
                var chanel = await Request.GetRequestSelectedChanel(id, token);
                SelectedChannelView chanelView = new SelectedChannelView(chanel);

                wynik.Text = chanelView.ToJson();
            }
            catch
            {
                MessageBox.Show("Brak danych");
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            int channel = 0;
            try
            {
                channel = int.Parse(txtChanel.Text);
            }
            catch
            {
                MessageBox.Show("Insert valid integer value for channel");
                return;
            }
            GetChanel(channel);
        }

        private void Window_Initialized(object sender, System.EventArgs e)
        {
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }
    }
}
