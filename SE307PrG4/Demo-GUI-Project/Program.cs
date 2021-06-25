using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE307PrG4GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string CurrentC = "Pastas";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine(CurrentC);
            Console.ReadLine();
        }
/*
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(textBox1);
            Console.SetOut(writer);
        }
*/
    }
    public class TextBoxWriter : TextWriter
    {

 // The control where we will write text.
        private Control MyControl;

        public TextBoxWriter(Control control)
        {
            MyControl = control;
        }

        public override void Write(char value)
        {
            MyControl.Text += value;
        }

        public override void Write(string value)
        {
            MyControl.Text += value;
        }

        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }

        }

    }
}
