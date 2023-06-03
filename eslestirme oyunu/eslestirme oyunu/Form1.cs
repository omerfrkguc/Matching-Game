namespace eslestirme_oyunu
{
    public partial class Form1 : Form
    {

        Label etk_1 = null;
        Label etk_2 = null;
        Random random = new Random();
        List<string> simge = new List<string>()
        {

         "!","!","N","N",",",",","k","k",
         "b","b","v","v","w","w","z","z"

        };

        private void HucrelereResimAta()
        {

            foreach (Control etk in tableLayoutPanel1.Controls)
            {

                Label resEtk = etk as Label;
                if (resEtk != null)
                {
                    int rs = random.Next(simge.Count);
                    resEtk.Text = simge[rs];
                    resEtk.ForeColor = resEtk.BackColor;
                    simge.RemoveAt(rs);

                }
            }



        }





        public Form1()
        {
            InitializeComponent();
            HucrelereResimAta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            Label secilenEtiket = sender as Label;
            if (secilenEtiket != null)
            {
                if (secilenEtiket.ForeColor == Color.Black)
                {
                    return;
                }
                if (etk_1 == null)
                {
                    etk_1 = secilenEtiket;
                    etk_1.ForeColor = Color.Black;
                    return;
                }

                etk_2 = secilenEtiket;
                etk_2.ForeColor = Color.Black;

                oyunBittimi();

                if (etk_1.Text == etk_2.Text)
                {
                    etk_1 = null;
                    etk_2 = null;
                    return;
                }
                timer1.Start();
            }
        }
        private void oyunBittimi()
        {
            foreach (Control etk in tableLayoutPanel1.Controls)
            {
                Label resEtk = etk as Label;
                if (resEtk != null)
                {
                    if (resEtk.ForeColor == resEtk.BackColor)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("Oyun Bitti!");
            Close();
        }

        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            etk_1.ForeColor = etk_1.BackColor;
            etk_2.ForeColor = etk_2.BackColor;
            etk_1 = null;
            etk_2 = null;
        }
    }
}