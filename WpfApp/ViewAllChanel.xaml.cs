using IO.Swagger.Model;
using Pd.Ratmon;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ViewAllChanel.xaml 
    /// </summary>
    public partial class ViewAllChanel : Window
    {
        public GetToken token;
        public ViewAllChanel(List<IO.Swagger.Model.AllCircuitsChannels> _l,
              GetToken _token)
        {
            InitializeComponent();       
            token = _token;
            //
            var listAll = new List<AllCircuitsChannelsView>();
            //
            foreach (var item in _l)
            {
                AllCircuitsChannelsView vItem = new AllCircuitsChannelsView();
                vItem.Id = item.Id;
                vItem.Name = item.Name;
                vItem.State = item.State;
                listAll.Add(vItem);
            }
            //
            dbGrid.ItemsSource = listAll;
            dbGrid.IsReadOnly = true;
        }

     
        private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {}

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //
            DataGridRow row = sender as DataGridRow;
            int id = 0;
            try
            {
                string s = row.Item.ToString();
                string[] lines = s.Split(new[] { "\n" },StringSplitOptions.None);
                id = int.Parse(lines[1].Replace("Id:", "").Trim());
            }
            catch
            {
                MessageBox.Show("Select valid Id row");
                return;
            }
            //
            ViewChanel v = new ViewChanel(id); 
            v.token = token;
            v.Button_Click(null, null);
            v.ShowDialog(); 
        }

        private void Window_Initialized(object sender, EventArgs e)
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
