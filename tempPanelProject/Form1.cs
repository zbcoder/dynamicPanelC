using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tempPanelProject
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;

            tableLayoutPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomPanel cs = new CustomPanel(this);
            cs.Create(tableLayoutPanel1, Convert.ToInt32(textBox1.Text));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 200));
            i++;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Refresh();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToInt16(textBox1.Text) > 20)
                {
                    MessageBox.Show("Не умеем генерировать столько :(\n Хорошо и быстро работает +-20 записей");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
                try
                {
                    int s = Convert.ToInt32(textBox1.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
        }
    }
}
