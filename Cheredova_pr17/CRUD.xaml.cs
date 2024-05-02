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

namespace Cheredova_pr17
{
    public partial class CRUD : Window
    {
        public CRUD(int x)
        {
            InitializeComponent();
            switch(x)
            {
                case 1:
                    Add_Data add_Data = new Add_Data();
                    MainFrame.Content = add_Data;
                    break;
                case 2:
                    Delete_page delete_Page = new Delete_page();
                    MainFrame.Content = delete_Page;
                    break;
                case 3:
                    Up Up = new Up();
                    MainFrame.Content = Up;
                    break;
            }
        }
    }
}
