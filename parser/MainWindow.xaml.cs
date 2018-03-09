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

namespace parser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string nothing_to_see_here { get; set; }

        public MainWindow()
        {
            this.sliderman_before_changed = 0;
            this.nothing_to_see_here = "don goofed";
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nothing_to_see_here = txtin.Text;
            int s = 0;
            Char[] specials = ("~!@#$%^&*_-+=,.`|(){}[]:;'<>?/").ToCharArray();

            Random rand = new Random();

            Dictionary<Type, int> dictionary = new Dictionary<Type, int>();
            List <string> outs = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                Char[] input = txtin.Text.ToCharArray();
                foreach (char c in input)
                {
                    //int test = (DateTime.Now.Second);

                    int d = rand.Next(100, 1000) % input.Length;
                    input[d] = specials[i % specials.Length];
                    i++;
                }
                outs.Add(new string (input));
            }

            //    //determine if text contains necessary characters
            //    //Exclude specific characters
            //    //Make passwords more memorable
            //    //User define Length 

            // Bug - longer inputs = smaller number of outputs

            txtout.Text = string.Join(" \n", outs.ToArray());
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Make the passwords memorable again!
        }
        public double sliderman_before_changed { get; set; }
        private void sliderman_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // change length of text in until temp is as long as sliderman

            if (txtin.Text == null || txtin.Text == "") 
            { 
                txtin.Text = nothing_to_see_here;
            }
            double value = Convert.ToInt64(sliderman.Value*10);
            char[] start = txtin.Text.ToCharArray();
            List<char> temp = start.ToList();
            int input_size = temp.Count;
            
            if (sliderman_before_changed <= value)
            {
                int i = 0;
                while (temp.Count < value)
                {
                    if (i >= input_size)
                    {
                        i = 0;
                    }
                    temp.Add(start[i]);

                    i++;
                }
            }
            // add functionality
            //Delete the most common characters first
            if (sliderman_before_changed > value)
            {
                int i = temp.Count-1;
                while (temp.Count > value)
                {
                    temp.Remove(start[i]);
                    i--;
                }
            }


            sliderman_before_changed = value;
            txtin.Text = String.Join("",temp.ToArray()); ;
        }
    }
}
