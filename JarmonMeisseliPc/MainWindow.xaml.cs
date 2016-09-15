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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using Newtonsoft.Json.Converters;

namespace JarmonMeisseliPc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var query = "";
            if (tag.Text != "")
            {
                query += "personTag:\"" + tag.Text + "\" ";        
                
            }
            if (toolId.Text != "")
            {
                query += "toolId:\"" + toolId.Text + "\"";
            }
           // HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("http://localhost:3000/api?query=InsertToolUse("+ query +")");
           // httpRequest.Method = "GET";
            string postData = "query:";
            postData += "InsertToolUse("+query+")";
            Console.WriteLine(postData);
            //var data = Encoding.ASCII.GetBytes(postData);
           // var response = (HttpWebResponse)httpRequest.GetResponse();
        }
    }
}
