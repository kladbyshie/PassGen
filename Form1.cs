using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name = String.Empty;
        private string seed = String.Empty;
        private string charcount = String.Empty;

        public string CoreName
        {
            get { return name; }
            set { name = value; }
        }

        public string Seed
        {
            get { return seed; }
            set { seed = value; }
        }
        public string CharCount
        {
            get { return charcount; }
            set { charcount = value; }
        }

        public void PassGen(string CoreName = "test", string Seed = "Test2", string CharCount = "10")
        {
            int newpass = 0;
            char[] chararray = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!?".ToArray();
            foreach(char c in CoreName)
            {
                int a = Convert.ToInt32(c);
                newpass += a;
            }
            foreach (char d in Seed)
            {
                int b = Convert.ToInt32(d);
                newpass += b;
            }
            Random rand = new Random(newpass);
            string password = String.Empty;
            for (int e = 0; e < Convert.ToInt32(CharCount); e++)
            {
                int a = rand.Next(0, chararray.Length);
                char ch = chararray[a];
                password += ch;
            }
            
            passField.Text = password;
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            CoreName = nameField.Text;
        }

        private void seedField_TextChanged(object sender, EventArgs e)
        {
            Seed = seedField.Text;
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void charField_TextChanged(object sender, EventArgs e)
        {
            CharCount = charField.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seedField.Text = "DefaultSeed";
            charField.Text = "10";
            nameField.Select();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            passField.Text = String.Empty;

            if (CoreName.Length > 0 || Seed.Length > 0 || CharCount.Length > 0)
            {
                PassGen(CoreName, Seed, CharCount);
            }
        }

    }
}
