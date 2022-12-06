namespace test
{
    public partial class Form1 : Form
    {
        public int rozmiar = 0;
        public static Form1 form1Instance;
        public string typ;
        public Form1()
        {
            InitializeComponent();
            form1Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    typ = "pies";
                    break;
                case 1:
                    typ = "kot";
                    break;
                case 2:
                    typ = "ma³pa";
                    break;
                case 3:
                    typ = "krokodyl";
                    break;
            }


            rozmiar = 0;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    rozmiar = 3;
                    break;
                case 1:
                    rozmiar = 4;
                    break;
                case 2:
                    rozmiar = 5;
                    break;
                case 3:
                    rozmiar = 6;
                    break;
                case 4:
                    rozmiar = 7;
                    break;
                case 5:
                    rozmiar = 8;
                    break;
                case 6:
                    rozmiar = 9;
                    break;
            }
            Form2 f2= new Form2();
            f2.ShowDialog();
            
        }
    }
}