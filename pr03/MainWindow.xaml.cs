using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static List<user> users = new List<user>();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        void Load() 
        {
            users.Add(new user
            {
                name = ta.Text,
                password = tb.Text,
            });
        }

        public class user 
        { 
            public string name { get; set; }
            public string password { get; set; }
        }

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            Load();
            foreach (var user in users) 
            { 
                lia.Items.Add(user);
            }
        }

        public List<> SortQuick(List<users>, int li, int ri) 
        { 
        
        }
    }
}
