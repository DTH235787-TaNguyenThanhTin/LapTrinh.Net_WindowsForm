﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi04_Bai_3
{
    
    
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int[] a) 
        {
            InitializeComponent();
            c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                c[i] = a[i];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int max = TimMax();
            MessageBox.Show("Số lớn nhất trong mảng là: " + max, "Kết quả");
        }
        private int TimMax()
        {
            int max = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                if (c[i] > max)
                    max = c[i];
            }
            return max;
        }
    }
}

