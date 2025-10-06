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
    public partial class Form2 : Form
    {
        int[] b;

        public Form2(int[] a)
        {
            InitializeComponent();
            b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                b[i] = a[i];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int sum = TongMang();

            MessageBox.Show("Tổng các phần tử trong mảng là: " + sum, "Kết quả");
        }
        private int TongMang()
        {
           
            int sum = b[0];
            for (int i = 0; i < b.Length; i++)
                sum += b[i];
            return sum;
        }

    }
}
