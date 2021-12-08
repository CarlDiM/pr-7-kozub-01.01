using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace pr_7_kozub_01._01
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        public ChangeWindow()
        {
            InitializeComponent();
        }

        public int? NewAge
        {
            get
            {
                if (inputNewAge.Text != string.Empty)
                    return Convert.ToInt32(inputNewAge.Text);
                else return null;
            }
        }

        public string? NewGroup
        {
            get
            {
                if (inputNewGroup.Text != string.Empty)
                    return inputNewGroup.Text;
                else return null;
            }
        }

        public float? NewWeight
        {
            get
            {
                if (inputNewWeight.Text != string.Empty)
                    return Convert.ToInt32(inputNewWeight.Text);
                else return null;
            }
        }

        public bool IsTransferred { get; set; }

        private void accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void transfer_Click(object sender, RoutedEventArgs e)
        {
            IsTransferred = true;
            DialogResult = true;
        }
    }
}
