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

namespace FirstApp
{
    /// <summary>
    /// ch7.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ch7 : Window
    {
        public ch7()
        {
            InitializeComponent();
        }

        private void Hyper_MouseEnter(object sender, MouseEventArgs e)
        {
            Hyper.TextDecorations = TextDecorations.Underline;
        }

        private void Hyper_MouseLeave(object sender, MouseEventArgs e)
        {
            Hyper.TextDecorations = null;
        }

        private void Hyper_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}
