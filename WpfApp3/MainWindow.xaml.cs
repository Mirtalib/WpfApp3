using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp3
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn is null)
                return;
            int index = txtBox1.Text.Length;
            string content = btn.Content.ToString()!;

           

            switch (content)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    txtBox1.Text += content;
                    break;
                case "CE":
                    txtBox1.Clear();
                    break;
                case "√":
                    {
                        if (index == 0)
                            break;
                        else
                        {
                            try
                            {
                                double a = Math.Sqrt(Double.Parse(txtBox1.Text));
                                txtBox1.Text = a.ToString();
                                break;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString());
                            }
                        }
                        break;
                    }
                case "=":
                    try
                    {
                        txtBox1.Text = new DataTable().Compute(txtBox1.Text, null).ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    break;
                case "x²":
                    {
                        if (index == 0)
                            break;
                        try
                        {
                            txtBox1.Text = ((float.Parse(txtBox1.Text)) * (float.Parse(txtBox1.Text))).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    break;
                case "/":
                    {
                        if (index == 0)
                            break;
                        else if (char.IsDigit(txtBox1.Text[index - 1]) || txtBox1.Text[index - 1] == '/' && btn.Content.ToString() != "/")
                            txtBox1.Text += content;
                        break;
                    }
                case "*":
                    {
                        if (index == 0)
                            break;
                        else if (char.IsDigit(txtBox1.Text[index - 1]) || txtBox1.Text[index - 1] == '*' && btn.Content.ToString() != "*" && btn.Content.ToString() != "*")
                            txtBox1.Text += content;
                        break;
                    }
                case "-":
                    {
                        if (index == 0)
                            break;
                        else if (char.IsDigit(txtBox1.Text[index - 1]) || txtBox1.Text[index - 1] == '-' && btn.Content.ToString() != "-")
                            txtBox1.Text += content;
                        break;
                    }
                case ".":
                    {
                        if (index == 0)
                            break;
                        else if (char.IsDigit(txtBox1.Text[index - 1]) || txtBox1.Text[index - 1] == '.' && btn.Content.ToString() != ".")
                            txtBox1.Text += content;
                        break;
                    }
                case "+":
                    {
                        if (index == 0)
                            break;
                        else if (char.IsDigit(txtBox1.Text[index - 1]) || txtBox1.Text[index - 1] == '+' && btn.Content.ToString() != "+")
                            txtBox1.Text += content;
                        break;
                    }
            }

        }

    } 
}
