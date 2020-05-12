using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ViewLayerSupport.Views
{
    /// <summary>
    /// CursorTypeToBooleanConverterWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class CursorTypeToBooleanConverterWindow : Window
    {
        public CursorTypeToBooleanConverterWindow()
        {
            InitializeComponent();
        }

        private void ChangeWait_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
        }
        private void ChangeCross_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }
    }
}
