namespace TriangleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint a, b, c;

            if (UInt32.TryParse(textBox1.Text, out a) &&
                UInt32.TryParse(textBox2.Text, out b) &&
                UInt32.TryParse(textBox3.Text, out c))
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                    MessageBox.Show("Это не треугольник");
                else
                {
                    if (a == b && b == c)
                        MessageBox.Show("Это равносторонний треугольник");
                    else if (a == b || a == c || b == c)
                        MessageBox.Show("Это равнобедренный треугольник");
                    else
                        MessageBox.Show("Это разносторонний треугольник");
                }                
            }
            else MessageBox.Show("Ошибка!!! Вводите только целые, положительные числа.");


        }     
    }
}
