using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Assignmentas.ViewModels
{
    public class LoginViewModel : Screen
        
    {

        public LoginViewModel()
        {
            
        }
        private void GridOfWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var move = sender as System.Windows.Controls.Grid;
            var win = Window.GetWindow(move);
            win.DragMove();
        }
        public void TimeIn()
        {
            
        }
    }
}
