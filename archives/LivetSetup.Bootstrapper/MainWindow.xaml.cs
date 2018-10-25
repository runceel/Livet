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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.Resources;
using System.IO;
using System.Diagnostics;

namespace LivetSetup.Bootstrapper
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            //cabファイルの取り出し

            var tempCabFileName = System.IO.Path.ChangeExtension(System.IO.Path.GetTempFileName(),"cab");

            using(var stream = (Application.GetResourceStream(new Uri("/LivetSetup.cab",UriKind.Relative)).Stream))
            using(var fileStream = new FileStream(tempCabFileName,FileMode.Create))
            {
                int b;
                while((b = stream.ReadByte()) != -1)
                {
                    fileStream.WriteByte((byte)b);
                }

                fileStream.Flush();
            }

            //cabファイルの展開

            var tempFoldername = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString();

            Directory.CreateDirectory(tempFoldername);

            var msiStartInfo = new ProcessStartInfo() { FileName = "expand", CreateNoWindow = true, UseShellExecute = false, Arguments = string.Format(@"""{0}"" -f:* ""{1}""", tempCabFileName, tempFoldername), };
            var msiExpandProcess = Process.Start(msiStartInfo);

            msiExpandProcess.WaitForExit();

            //インストール

            var selectedCulture = ((ComboBoxItem)mainComboBox.SelectedItem).Content.ToString();
            var msiExecArgument = selectedCulture == "English (en-US)" ? string.Format(@"/i ""{0}""  /l logfile.txt", tempFoldername + "\\LivetSetup_en_US.msi")
                : string.Format(@"/i ""{0}""  /l logfile.txt", tempFoldername + "\\LivetSetup_ja_JP.msi");

            var msiExecStartInfo = new ProcessStartInfo() { FileName = "msiexec", Arguments = msiExecArgument };

            var msiExecProcess = Process.Start(msiExecStartInfo);

            msiExecProcess.WaitForExit();

            Directory.Delete(tempFoldername,true);

            Environment.Exit(0);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainWindow_ContentRendered(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentCulture.Name == "ja-JP")
            {
                mainComboBox.SelectedItem = mainComboBox.Items.Cast<ComboBoxItem>().Where(c => (string)c.Content == "日本語 (ja-JP)");
            }
            else
            {
                mainComboBox.SelectedItem = mainComboBox.Items.Cast<ComboBoxItem>().Where(c => (string)c.Content == "English (en-US)");
            }

            okButton.Focus();
        }
    }
}
