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

        Dictionary<char, string> temmemem = new Dictionary<char, string>();
        public string lastSavedInput { get; set; }

        public MainWindow()
        {
            temmemem.Add(Convert.ToChar("r"), "revolver");
            temmemem.Add(Convert.ToChar("o"), "ocelot");

            this.SavedSliderValue = 0;
            this.lastSavedInput = "don goofed";
            InitializeComponent();
        }
        private void Generate_passwords(object sender, RoutedEventArgs e)
        {
            lastSavedInput = txtin.Text;
            string work = lastSavedInput;
            Char[] input = txtin.Text.ToCharArray();
            Random rand = new Random();
            List<string> outs = new List<string>();

            if (memorablePasswords.IsChecked ?? true)
            {
                Dictionary<int, char[]> list = new Dictionary<int, char[]>();
                int counter = 0;
                int increment = 0;
                foreach(char c in input)
                {
                    foreach (KeyValuePair<char, string> kvp in temmemem)
                    {
                        if (c == kvp.Key)
                        {
                            list.Add(counter, kvp.Value.ToCharArray());

                            work = work.Insert(counter + increment, kvp.Value.ToString());
                        }
                    }
                    counter++;
                }
                input = work.ToCharArray();
            }
            if (NoSpecials.IsChecked ?? true)
            {
                outs.Add("sorry den del er ikke færdigt");
            }
            else { 
                Char[] specials = ("~!@#$%^&*_-+=,.`|(){}[]:;'<>?/").ToCharArray();
                for (int i = 0; i < 100; i++)
                {
                    foreach (char c in input)
                    {
                        //int test = (DateTime.Now.Second);
                        //some percent specials can come in here
                        int d = rand.Next(100, 1000) % input.Length;
                        input[d] = specials[i % specials.Length];
                        i++;
                    }
                    outs.Add(new string(input));
                }
            }

            txtout.Text = string.Join(" \n", outs.ToArray());
        }

        public double SavedSliderValue { get; set; }
        private void passwordLengthslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // change length of text in until temp is as long as sliderman

            if (txtin.Text == null || txtin.Text == "") 
            { 
                txtin.Text = lastSavedInput;
            }
            double SliderLength = Convert.ToInt64(sliderman.Value*10);
            char[] start = txtin.Text.ToCharArray();
            List<char> temp = start.ToList();
            int input_size = temp.Count;
            
            if (SavedSliderValue <= SliderLength)
            {
                int i = 0;
                while (temp.Count < SliderLength)
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
            if (SavedSliderValue > SliderLength)
            {
                int i = temp.Count-1;
                while (temp.Count > SliderLength)
                {
                    temp.Remove(start[i]);
                    i--;
                }
            }
            SavedSliderValue = SliderLength;
            txtin.Text = String.Join("",temp.ToArray()); ;
        }
        private void memorablePasswords_Checked(object sender, RoutedEventArgs e)
        {
            //Make the passwords memorable again!
            
            if (memorablePasswords.IsChecked ?? false) { }
        }
    }
}
