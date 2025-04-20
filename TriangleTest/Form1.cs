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
                    label3.Text = "����� ����������� �� ����������";
                else
                {
                    if (a == b && b == c)
                        label3.Text = ("��� �������������� �����������");
                    else if (a == b || a == c || b == c)
                        label3.Text = ("��� �������������� �����������");
                    else
                        label3.Text = ("��� �������������� �����������");
                }                
            }
            else label3.Text = ("������!!! ������� ������ �����, ������������� �����.");


        }     
    }
}
