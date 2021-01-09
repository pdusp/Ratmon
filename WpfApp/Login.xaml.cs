using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
 
        public Login()
        {
            InitializeComponent();
            txtusername.Text = Properties.Resources.username;
            txtpassword.Text = Properties.Resources.password;   
        }
 
            public string username { get; set; }
            public string password { get; set; }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //validation
            if (txtusername.Text=="")
            {
                MessageBox.Show("Podaj usera!");
                return;
            }

            if (txtpassword.Text == "")
            {
                MessageBox.Show("Podaj password!");
                return;
            }

            username = txtusername.Text;
            password= txtpassword.Text;    

            Close();
        }
    }
}
