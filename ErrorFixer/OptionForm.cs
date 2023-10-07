using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorFixer
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ShouldFixErrors    = ErrorFixCheckBox.Checked;
            Properties.Settings.Default.ShouldFixRendering = RenderingFixCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            ErrorFixCheckBox.Checked     = Properties.Settings.Default.ShouldFixErrors;
            RenderingFixCheckBox.Checked = Properties.Settings.Default.ShouldFixRendering;
        }
    }
}
