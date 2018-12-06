using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace Module_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        int count;
        List<TextBox> textBoxes = new List<TextBox>();
        static object locker = new object();
        bool cancel = false;

        public MainWindow()
        {
            InitializeComponent();
            count = 0;
        }   

        private async Task DownloadImage(object URL)
        {
            WebClient image = new WebClient();

            string url = URL.ToString();
            string fileExept = url.Split('.').Last();

             await image.DownloadFile(url, count + "." + fileExept);          
            lock (locker)
            {
                    
            }
           
        }


      
        // использовать таски вместо потока ограничить колиество исполняемых потоков
        // скачаневание сделать асинхроным
        // ограниччить количесто
        // конслейшен токен прерывание тасок
              
    


        private void StartDownload()
        {
            prog.Maximum = textBoxes.Count;
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if(cancel == true)
                {
                    break;
                }

                prog.Value = i+1;

                Task task = new Task(DownloadImage(""));
               // newThread.Start(textBoxes[i].Text);
                count = i;
            }

            MessageBox.Show("Done");
            EndDownload();
        }

        private void EndDownload()
        {
            prog.Value = 0;
            Stack.Children.RemoveRange(1, Stack.Children.Count - 1);
            textBoxes = new List<TextBox>();
            count = 0;
        }

        private void InputInTextboxes()
        {
            for (int i = 0; i < Stack.Children.Count; i++)
            {
                if (Stack.Children[i] is TextBox)
                {
                    textBoxes.Add(Stack.Children[i] as TextBox);
                }
            }
        }

        private void AddLineForDownLoad()
        {
            var stackPanel = Stack;
            stackPanel.Children.Add(new Label { Content = "Image URl", });
            stackPanel.Children.Add(new TextBox { Width = 724 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddLineForDownLoad();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputInTextboxes();            
            StartDownload();          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cancel = true;
            EndDownload();
        }
    }
}
