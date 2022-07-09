using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interprete_Prolog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.treeView1.BeginUpdate();
            this.treeView1.Nodes.Add("Padre");
            this.treeView1.Nodes[0].Nodes.Add("Hijo 1");
            this.treeView1.Nodes[0].Nodes.Add("Hijo 2");
            this.treeView1.Nodes[0].Nodes[1].Nodes.Add("Nieto");
            this.treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Bisnietos");
            this.treeView1.EndUpdate();
        }
    }
}
