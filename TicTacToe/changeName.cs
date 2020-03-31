using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class changeName : Form
    {
        public changeName()
        {
            InitializeComponent();
        }


        private void bttn_go_Click(object sender, EventArgs e)
        {
            Form1 newName = new Form1(first_Player.Text, second_Player.Text);
            newName.Show();
            this.Close();
        }

    }
}
