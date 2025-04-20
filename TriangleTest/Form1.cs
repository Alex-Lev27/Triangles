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
                    label3.Text = "Такой треугольник не существует";
                else
                {
                    if (a == b && b == c)
                        label3.Text = ("Это равносторонний треугольник");
                    else if (a == b || a == c || b == c)
                        label3.Text = ("Это равнобедренный треугольник");
                    else
                        label3.Text = ("Это разносторонний треугольник");
                }                
            }
            else label3.Text = ("Ошибка!!! Вводите только целые, положительные числа.");


        }     
    }
}
