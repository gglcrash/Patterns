﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Flyweight;

namespace WindowsFormsApplication1
{
    public partial class FlyweightForm : Form
    {
        public FlyweightForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ShapeFactory.resetDictionary();  //сброс словаря при новом запуске
            FlyweightExample example = new FlyweightExample(); 
            richTextBox1.Text = example.start();
        }
    }
}
