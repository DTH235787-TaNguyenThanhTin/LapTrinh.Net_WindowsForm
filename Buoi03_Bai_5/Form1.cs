namespace Buoi3_bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int TimMax(int so1, int so2)
        {
            if (so1 < so2)
                return so1;
            else
                return so2;
        }
        public string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b); string chuoi = "";
            for
            (int i = 1; i <= max; i++)
                if ((a % i == 0) && (b % i == 0))
                    chuoi += " " + i.ToString();
            return chuoi;
        }
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a
                    - b;
                else
                    b = b
                    - a;
            }
            return a;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtN.Text);
            b = int.Parse(this.txtM.Text);
            if (this.rdo1.Checked == true)
                this.txtKq.Text = TimUocChung(a, b);
            if (this.rdo2.Checked == true)
                this.txtKq.Text = timUCLN(a, b).ToString();
        }
    }
}
