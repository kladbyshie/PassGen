using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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

        public string CoreName { get; set; }
        public string Seed { get; set; }
        public string CharCount { get; set; }

        public void PassGen(string CoreName = "Default", string Seed = "Default", string charcount = "10")
        {
            int newpass = 0;
            int CharCount = Convert.ToInt32(charcount);
            char[] lowercasearray = "abcdefghijklmnopqrstuvwxyz".ToArray();
            char[] uppercasearray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
            char[] numberarray = "0123456789".ToArray();
            char[] specialarray = "!?".ToArray();
            foreach (char c in CoreName)
            {
                int a = Convert.ToInt32(c);
                newpass += a;
            }
            foreach (char d in Seed)
            {
                int b = Convert.ToInt32(d);
                newpass += b;
            }
            //This creates a new seed from the combination of the core name and the seed value and creates a random object
            Random rand = new Random(newpass);
            string password = String.Empty;
            int ModifiedCharCount = CharCount;

            //Creates random random distribution that will always add up to CharCount and have at least 1 of each type of char
            var AllTotals = new List<int>();
            for (int i = 0; i < 3; i++)
                {
                int num = rand.Next(1, ModifiedCharCount - (3 - i));
                ModifiedCharCount -= num;
                AllTotals.Add(num);
                }
            AllTotals.Add(ModifiedCharCount);

            int upperquant = AllTotals[0];
            int lowerquant = AllTotals[1];
            int numquant = AllTotals[2];
            int specialquant = AllTotals[3];

            for (int e = 0; e < lowerquant; e++)
            {
                int a = rand.Next(0, lowercasearray.Length);
                char ch = lowercasearray[a];
                password += ch;
            }
            for (int e = 0; e < upperquant; e++)
            {
                int a = rand.Next(0, uppercasearray.Length);
                char ch = uppercasearray[a];
                password += ch;
            }
            for (int e = 0; e < numquant; e++)
            {
                int a = rand.Next(0, numberarray.Length);
                char ch = numberarray[a];
                password += ch;
            }
            for (int e = 0; e < specialquant; e++)
            {
                int a = rand.Next(0, specialarray.Length);
                char ch = specialarray[a];
                password += ch;
            }

            //Shuffles the chars around within the string
            char[] NewPassword = password.ToCharArray();
            for (int i = 0; i < NewPassword.Length; i++)
            {
                int j = rand.Next(i, NewPassword.Length); 
                char temp = NewPassword[i];
                NewPassword[i] = NewPassword[j];
                NewPassword[j] = temp;
            }

            password = new string(NewPassword);

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
            //These are defaults; can be changed per user 
            seedField.Text = "DefaultSeed";
            charField.Text = "10";
            nameField.Select();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            passField.Text = String.Empty;
            PassGen(CoreName, Seed, CharCount);
        }

    }
}
