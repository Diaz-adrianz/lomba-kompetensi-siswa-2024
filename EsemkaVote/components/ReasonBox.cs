using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaVote.components
{
    public partial class ReasonBox : Form
    {
        public ReasonBox()
        {
            InitializeComponent();
        }

        public void setContentText(string content)
        {
            TexContent.Text = content;
        }
    }
}
