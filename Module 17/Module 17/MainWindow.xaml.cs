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
        List<TextBox> textBoxes = new List<TextBox>();
        Semaphore sm = new Semaphore(3, 3);
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken ct;



        public MainWindow()
        {
            InitializeComponent();
            Download.IsEnabled = false;            
            ct = tokenSource.Token;
        }   

        private async Task DownloadImage(string url)
        {
           WebClient image = new WebClient();
           string fileExept = url.Split('.').Last();
           Random rnd = new Random();
           sm.WaitOne();
           await image.DownloadFileTaskAsync(url, rnd.Next() + "." + fileExept);
           sm.Release();
        }
             
             
        private void StartDownload()
        {
            prog.Maximum = textBoxes.Count;           

            for (int i = 0; i < textBoxes.Count; i++)
            {
              string tmp = textBoxes[i].Text; 
              Task.Factory.StartNew(() => DownloadImage(tmp)).Wait();

              prog.Value = i+1;               
            }
            Cansel.Content = "Cancel";         
        }

        private void Cancel()
        {
            try
            {
                ct.ThrowIfCancellationRequested();
            }          
            finally
            {
                tokenSource.Dispose();
            }

        }

        private void EndDownload()
        {
            if(Cansel.Content.ToString() == "Cancel")
            {

            }
            else
            {
                MessageBox.Show("Cleaned!");
                prog.Value = 0;
                Stack.Children.RemoveRange(1, Stack.Children.Count - 1);
                textBoxes = new List<TextBox>();
                Download.IsEnabled = true;
                ct.ThrowIfCancellationRequested();
            }

          
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
            Download.IsEnabled = true;           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add.IsEnabled = false;
            InputInTextboxes();            
            StartDownload();
            Download.IsEnabled = false;
            Cansel.Content = "Reset";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {        
            EndDownload();
            Cansel.Content = "Reset";
            Add.IsEnabled = true;
            Download.IsEnabled = false;     
        }
    }
}
