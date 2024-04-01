namespace Lab5OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Рядок 1:";
            label2.Text = "Рядок 2:";
            label3.Text = "Рядок 3:";
            label4.Text = "Результат:";
            btnOK.Text = "Порахувати";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            char var1 = txtString1.Text.Length > 0 ? txtString1.Text[0] : '0';
            char var2 = txtString2.Text.Length > 0 ? txtString2.Text[0] : '0';
            char var3 = txtString3.Text.Length > 0 ? txtString3.Text[0] : '0';

            int concatenatedInt = (var1 - '0') * 100 + (var2 - '0') * 10 + (var3 - '0');

            if (!char.IsDigit(var1) || !char.IsDigit(var2) || !char.IsDigit(var3))
            {
                MessageBox.Show("Не вдалося сформувати число з цих символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblResult.Text = $"Число: {concatenatedInt}";
            }
        }
    }
}
