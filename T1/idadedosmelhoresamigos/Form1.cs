using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idadedosmelhoresamigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadesamira = 45;
            int idadepedro = 14;
            int idadesandra = 44;
            int media = (idadepedro + idadesamira + idadesandra) / 3;
            MessageBox.Show("media de idades é:" + media);
        }
    }
}
