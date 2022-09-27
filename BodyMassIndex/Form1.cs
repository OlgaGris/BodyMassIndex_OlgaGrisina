namespace BodyMassIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double w, h, bmi;
            String status;
            try
            {
                w = double.Parse(weight.Text);
                h = double.Parse(height.Text)/100;
                bmi = w / (h*h);
                if (bmi > 24)
                {
                    status = "overweight";
                }
                else if (bmi < 18.5)
                {
                    status = "underweight";
                }
                else
                {
                    status = "optimal";
                }
                result.Text ="BMI: "+ bmi.ToString("#.##") +"\nStatus: "+ status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}