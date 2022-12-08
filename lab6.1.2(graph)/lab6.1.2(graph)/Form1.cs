namespace lab6._1._2_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Input(out int n, out int m) // out - ����������� ���������� �� ������;
                                               // ����������, ������������ � �������� ����������, �� ��������� ���������������� ����� ��������� � ������ ������.
                                               // ����� �������� � ��������� �������������� � ����������
            {
                    try
                    {
                        if (numericUpDown1.Value <= 0 || numericUpDown2.Value <= 0)
                        {
                            MessageBox.Show("������! ����������� ������� �� ����� ����� ������������� ��� ������� ��������", "������",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("������! �������� ������ ����� ������", "������",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                n = (int)numericUpDown1.Value;
                m = (int)numericUpDown2.Value;

                int[,] array = new int[n, m];
                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = rand.Next(-100, 100);
                    }
                }
                        
                return array;
            }

            void Print(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    textBox1.Text += Environment.NewLine;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        textBox1.Text += $"{array[i, j]} ";
                    }
                      
                }
                    
            }
            void Sum(int[,] array)
            {
                int sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                }
                if (sum < 10 || sum > 99)
                {
                    textBox1.Text += $"����� ��������� ����� {sum} - �� ���������� �����";
                }
                else
                {
                    textBox1.Text += $"����� ��������� ����� {sum} - ���������� �����" + Environment.NewLine;
                }
            }

            {
                int n, m;
                int[,] Array = Input(out n, out m);
                Print(Array);
                Sum(Array);
            }

        }
    }
}