using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detention
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            var listBoxItems = packagesCLB.Items;
            listBoxItems.Add("Simple Responses");
            listBoxItems.Add("Simple Arithmetic");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(detentionTimeLabel.Text, @"^\d+$"))
            {
                Form detention = new Detention(Convert.ToInt32(detentionTimeLabel.Text) * 60);
                detention.Show();
            }
            else
            {
                MessageBox.Show("Invalid detention time!", "Error");
            }
        }

        private void detentionTimeLabel_Updated(object sender, EventArgs e)
        {

        }
    }
}
