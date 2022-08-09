using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discord_rpc_example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Program.client.UpdateDetails("In Form2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 GetForm1 = new Form1();
            GetForm1.Show();
            this.Hide();
        }
    }
}
