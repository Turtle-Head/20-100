using System;

namespace RayEx1
{

    public partial class Form1 : Form
    {
        int[] twtp = new int[20];
        int[] narry = new int[100];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void b1_Click(object sender, EventArgs e)
        {
            int evn = 0;
            int odc = 0;
            int zr = 0;
            Double tots = 0;
            Double avg = 0;
            output.Clear();
            for (int b = 0; b < narry.Length; b++)
            {
                narry[b] = random.Next(0, 100);
                if (narry[b] == 0) { zr++; }
                else if (narry[b] % 2 == 0) { evn++; }
                else if (narry[b] % 2 != 0) { odc++; };
            }
            /*    Bubble sort */
            //output.Clear();
            for (int i = 0; i < narry.Length; i++)
            {
                for (int j = i + 1; j < narry.Length; j++)
                {
                    if (narry[i] > narry[j])
                    {
                        int tmp = narry[j];
                        narry[j] = narry[i];
                        narry[i] = tmp;
                    }
                }
            }
            for (int i = 0; i < narry.Length; i++)
            {
                output.Text += $"{narry[i]}, ";
                tots += narry[i];
            }
            avg = tots / narry.Length;
            output.Text += $"\n Even: {evn} \n Odd: {odc} \n Zeros: {zr}\n";
            output.Text += $"Sum: {tots}";
            output.Text += $"\n Average: {avg}";
            output.Text += $"\n Smallest: {narry[0]}";
            output.Text += $"\n Largest: {narry[narry.Length - 1]}";
        }

        private void twt_Click(object sender, EventArgs e)
        {
            int evn = 0;
            int odc = 0;
            int zr = 0;
            Double tots = 0;
            Double avg = 0;
            output.Clear();
            for (int b = 0; b < twtp.Length; b++)
            {
                twtp[b] = random.Next(0, 20);
                if (twtp[b] == 0) { zr++; }
                else if (twtp[b] % 2 == 0) { evn++; }
                else if (twtp[b] % 2 != 0) { odc++; };
            }
            /*    Bubble sort */
            //output.Clear();
            for (int i = 0; i < twtp.Length; i++)
            {
                for (int j = i + 1; j < twtp.Length; j++)
                {
                    if (twtp[i] > twtp[j])
                    {
                        int tmp = twtp[j];
                        twtp[j] = twtp[i];
                        twtp[i] = tmp;
                    }
                }
            }
            for (int i = 0; i < twtp.Length; i++)
            {
                output.Text += $" {twtp[i]},";
                tots += twtp[i];
            }
            avg = tots / twtp.Length;
            output.Text += $"\n Even: {evn} \n Odd: {odc} \n Zeros: {zr}\n";
            output.Text += $"Sum: {tots}";
            output.Text += $"\n Average: {avg}";
            output.Text += $"\n Smallest: {twtp[0]}";
            output.Text += $"\n Largest: {twtp[twtp.Length - 1]}";
        }
    }
}