using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignmentas.ViewModels
{
    public class ShellViewModel : Screen
    {
        public void LoginButton(String UserName)
        {
            MessageBox.Show(String.Format("Welcome {0}",UserName));
        }
    }
}
