using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    
    public partial class Form2 : Form
    {
        public int seconds = 0;
        Form3 f3= new Form3();
        Form4 f4 = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            var rowCount = Form1.form1Instance.rozmiar;
            var columnCount = Form1.form1Instance.rozmiar;

            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            var lowerBound = 0;
            var upperBound = rowCount;
            var random_row = RandomNumberGenerator.GetInt32(lowerBound, upperBound);
            upperBound = columnCount;
            var random_column = RandomNumberGenerator.GetInt32(lowerBound, upperBound);



            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if(i == random_row && j == random_column)
                    {
                        var button = new Button();
                        button.Name = string.Format("button_{0}{1}", i, j);
                        button.Dock = DockStyle.Fill;

                        switch(Form1.form1Instance.typ)
                        {
                            case "pies":
                                button.Click += (sender, e) => button.BackgroundImage = Resource1.dog;
                                button.Click += (sender, e) => timer1.Stop();
                                button.Click += (sender, e) => f4.ShowDialog();
                                break;
                            case "kot":
                                button.Click += (sender, e) => button.BackgroundImage = Resource1.cat;
                                button.Click += (sender, e) => timer1.Stop();
                                button.Click += (sender, e) => f4.ShowDialog();
                                break;
                            case "małpa":
                                button.Click += (sender, e) => button.BackgroundImage = Resource1.monkey;
                                button.Click += (sender, e) => timer1.Stop();
                                button.Click += (sender, e) => f4.ShowDialog();
                                break;
                            case "krokodyl":
                                button.Click += (sender, e) => button.BackgroundImage = Resource1.crocodile;
                                button.Click += (sender, e) => timer1.Stop();
                                var dolnylimit = 0;
                                var gornylimit = 1;
                                var los = RandomNumberGenerator.GetInt32(lowerBound, upperBound);

                                if(los == 0)
                                {
                                    button.Click += (sender, e) => f3.ShowDialog();
                                }
                                else
                                {
                                    button.Click += (sender, e) => f4.ShowDialog();
                                }

                                break;
                        }
                        
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                        button.Enabled = false;
                        button1.Click += (sender, e) => button.Enabled = true;
                        
                        this.tableLayoutPanel1.Controls.Add(button, j, i);
                    }
                    else
                    {
                    var button = new Button();
                    button.Name = string.Format("button_{0}{1}", i, j);
                    button.Dock = DockStyle.Fill;
                    button.Click += (sender, e) => button.Visible = false;
                    button.Enabled= false;
                    button1.Click += (sender, e) => button.Enabled = true;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                    }

                    
                }
            }  
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if(seconds < 0) 
            {
                timer1.Stop();
                this.Hide();
                
                f3.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = 3;
            timer1.Start();
        }
    }
}
