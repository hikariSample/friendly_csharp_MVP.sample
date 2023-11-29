using System.Windows;
using MVP.Sample.WPF.Models;

namespace MVP.Sample.WPF.Views.Person
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public PersonViewModel Model
        {
            get
            {
                return this.DataContext as PersonViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
    }
}
