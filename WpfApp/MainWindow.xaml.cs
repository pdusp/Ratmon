using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using IO.Swagger.Model;
using Pd.Ratmon;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         
        public GetToken token;
        public List<AllCircuits> allcircut;

        //Model: https://app.swaggerhub.com/apis/M9626/api-ratmon/1.0.0-oas3#trial

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = "";
            string password = "";
            //
            Login l = new Login();
            l.ShowDialog();
            username = l.username;
            password = l.password;
            //
            try
            {
                token = await Pd.Ratmon.Request.PostRequestAuth(username, password);
            }
            catch
            {
                MessageBox.Show(String.Format("User name or password is not valid!"));
                return;
            }
            Console.WriteLine(token);
            ButtonLogin.IsEnabled = false;
            btnAllCircut.IsEnabled = true;
            btnGetChanel.IsEnabled = true;
        }

        private async void btnGetAllCircut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                allcircut = await Request.GetRequestAllCircuits(token);
                var ListAll  = new List<AllCircuitsView>();
                //
                foreach (var item in allcircut)
                {
                    AllCircuitsView vItem = new AllCircuitsView();
                    vItem.Id = item.Id;
                    vItem.Channels = item.Channels;
                    vItem.Detector = item.Detector;
                    vItem.Localization = item.Localization;
                    vItem.Number = item.Number;
                    vItem.State = item.State;
                    //vItem.StateView = item.State;
                    ListAll.Add(vItem);
                }
                //
                dbGrid.ItemsSource = ListAll;
                dbGrid.IsReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Error!");
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewChanel v = new ViewChanel(12);
                v.token = token;
                AllCircuitsView allCircutsView = new AllCircuitsView();
                v.ShowDialog(); 
            }
            catch
            {
                MessageBox.Show("Error!");
                return;
            }
        }


        private void Row_DoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            int id = 0;
            try
            {
                string s = row.Item.ToString();
                string[] lines = s.Split(
                new[] { "\n" },
                StringSplitOptions.None
                );
                id = int.Parse(lines[1].Replace("Id:", "").Trim());
            }
            catch
            {
                MessageBox.Show("Select valid Id row");
                return;
            }
            //
            ViewAllChanel v = null;
            try
            {
                var channels = allcircut.Where(ss => ss.Id == id).First();
                v = new ViewAllChanel(channels.Channels, token);
            }
            catch
            {
                MessageBox.Show("Error!");
                return;
            }
            //
            v.ShowDialog();
        }
    }
}
