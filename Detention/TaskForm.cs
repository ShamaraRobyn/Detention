﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detention
{
    public partial class TaskForm : Form
    {
        Task task;

        public TaskForm()
        {
            InitializeComponent();
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
