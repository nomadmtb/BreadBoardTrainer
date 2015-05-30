using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BreadBoardTrainer
{
    class Demo1
    {
        private Window _topWindow;
        private Window _lowerWindow;

        public void Demo1(Window mainWindow)
        {
            _topWindow = mainWindow;
            _lowerWindow = new LowerWindow();
        }
    }
}
