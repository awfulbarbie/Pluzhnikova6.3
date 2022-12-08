using System.Windows.Forms;

namespace lab6._1._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Input()
            {
                int n = 0;

                try
                    {
                        if (numericUpDown1.Value <= 0)
                        {
                            MessageBox.Show("Ошибка! Размерность массива не может иметь отрицательное или нулевое значение");
                        }
                    }
                catch
                    {
                      MessageBox.Show("Ошибка! Неверный формат ввода данных");
                    }
                    n = (int)numericUpDown1.Value;

                int[] array = new int[n];

                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    array[i] = rand.Next(-100, 100) ;
                }
                return array;
            }
            void Print(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    textBox1.Text += $"{array[i]} " + Environment.NewLine;
                }
            }
            void Sum(int[] array)
            {
                int m = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    m += array[i];
                }
                if (m < 10 || m > 99)
                {
                    textBox1.Text += ($"Сумма элементов равна {m} - не двузначное число");
                }
                else
                {
                    textBox1.Text += ($"Сумма элементов равна {m} - двузначное число");
                }

            }

            {
                int[] Array = Input();
                Print(Array);
                Sum(Array);
            }
        }
    }

}
    
