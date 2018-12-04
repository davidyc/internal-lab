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
        //List<Task> tasks = new List<Task>();
        List<TextBox> textBoxes = new List<TextBox>();
        bool cancel = false;

        public MainWindow()
        {
            InitializeComponent();
            
        }    


        private void DownloadImage(object URL)
        {
            WebClient image = new WebClient();
            image.DownloadFile(URL.ToString(), "1.jpeg");
        }


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

                Thread newThread = new Thread(DownloadImage);
                newThread.Start(textBoxes[0].Text);              
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var stackPanel = Stack;
            stackPanel.Children.Add(new Label { Content = "Image URl",});
            stackPanel.Children.Add(new TextBox { Width = 724 });    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            for (int i = 0; i < Stack.Children.Count; i++)
            {                
                if(Stack.Children[i] is TextBox)
                {
                    textBoxes.Add(Stack.Children[i] as TextBox);
                } 
            }

            StartDownload();
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cancel = true;
        }
    }
}
