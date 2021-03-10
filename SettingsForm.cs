using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlowDown
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Settings.CBTime = int.Parse(txtTime.Text);
            Settings.CBPercentage = int.Parse(txtPercentage.Text);
            Program.mainform.UpdateSettings();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtPercentage.Text = Settings.CBPercentage.ToString();
            txtTime.Text = Settings.CBTime.ToString();
        }
    }
}
