using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            



        }
        public int[,] ar = new int[10, 3] { { 1, 2, 3 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0,0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public int[,] sklad = new[,] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 } };
        public int[,] carrot = new[,] { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }, { 5, 1 }, { 6, 1 }, { 7, 1 }, { 8, 1 }, { 9, 1 } };
        public int[,] potato = new[,] { { 1, 2 }, { 2, 2 }, { 3, 2 }, { 4, 2 }, { 5, 2 }, { 6, 2 }, { 7, 2 }, { 8, 2 }, { 9, 2 } };
        public int i = 0;
        public int j = 0;




        //кнопка добавить
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Заполните все поля");
            else
            {

                if (i >= 10) i = 0;
                int n = 1;
                ar[sklad[i, j], sklad[i, j + n]] = int.Parse(textBox1.Text);
                ar[carrot[i, j], carrot[i, j + n]] = int.Parse(textBox2.Text);
                ar[potato[i, j], potato[i, j + n]] = int.Parse(textBox3.Text);
                n++;
                i++;

                MessageBox.Show("Добавлено");
            }

        }


        //кнопка Вывести текущий массив
        private void button2_Click(object sender, EventArgs e)
        {
            

          
                //указываем контроллу в который пишем количество строк и столбцов
                dataGridView1.RowCount = ar.GetLength(0);
                dataGridView1.ColumnCount = ar.GetLength(1);
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++)
                    {
                        //пишем значения из массива в ячейки контролла
                        dataGridView1.Rows[i].Cells[j].Value = ar[i, j];
                    }
                }

            
        }


        //кнопка Отфильтровать
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox4.Text != "")
            {
                dataGridView1.RowCount = ar.GetLength(0);
                dataGridView1.ColumnCount = ar.GetLength(1);
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++)
                    {
                        //пишем значения из массива в ячейки контролла
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                }

                dataGridView1.RowCount = ar.GetLength(0);
                dataGridView1.ColumnCount = ar.GetLength(1);

                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    for (int j = 0; j < ar.GetLength(1); j++)
                    {


                        if (ar[i, 0] == int.Parse(textBox4.Text))
                            //пишем значения из массива в ячейки контролла
                            dataGridView1.Rows[i].Cells[j].Value = ar[i, j];
                    }
                }
            }
            else MessageBox.Show("Заполните поле");






        }


        //кнопка Вывести номера складов
        private void button4_Click(object sender, EventArgs e)
        {
           
            int num1=0,num2=0,num3=0,num4=0,num5=0;
            int num11 = 0, num22 = 0, num33 = 0, num44 = 0, num55 = 0;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {

                   

                }
                if (ar[i, 0] == 1)
                { num1 = ar[i, 1] + ar[i, 2]; num11 += num1; }
                if (ar[i, 0] == 2)
                { num2 = ar[i, 1] + ar[i, 2]; num22 += num2; }
                if (ar[i, 0] == 3)
                { num3 = ar[i, 1] + ar[i, 2]; num33 += num3; }
                if (ar[i, 0] == 5)
                { num4 = ar[i, 1] + ar[i, 2]; num44 += num4; }
                if (ar[i, 0] == 5)
                { num5 = ar[i, 1] + ar[i, 2]; num55 += num5; }

            }
            if (textBox5.Text != "")
            {
                if (num11 < int.Parse(textBox5.Text)) MessageBox.Show("1");
                if (num22 < int.Parse(textBox5.Text)) MessageBox.Show("2");
                if (num33 < int.Parse(textBox5.Text)) MessageBox.Show("3");
                if (num44 < int.Parse(textBox5.Text)) MessageBox.Show("4");
                if (num55 < int.Parse(textBox5.Text)) MessageBox.Show("5");
            }
            else MessageBox.Show("заполните поле");


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
