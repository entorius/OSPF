using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Laboratorinis_OSPFWinForm
{
    public partial class DeleteRoute : Form
    {
        Form1 form1;
        public DeleteRoute(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }
        
        private void button_Atsaukti_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }

        private void button_Istrinti_Click(object sender, EventArgs e)
        {
            bool parsedPathNumber = Int32.TryParse(this.textBox_PathNumber.Text, out int PathNumber);
            if(form1.network.paths.Count > PathNumber && PathNumber > 0 && parsedPathNumber)
            {
                form1.network.DeleteRoute(form1.network.GetPaths()[PathNumber]);
                System.Console.WriteLine("Kelias ištrintas sėkmingai");
                form1.Show();
                Hide();
            }
            else
            {
                System.Console.WriteLine("Kelio ištrinti nepavyko");
            }
        }
    }
}
