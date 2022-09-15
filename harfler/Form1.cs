namespace harfler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Tamam";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<char> harf_listesi = new List<char>();
            List<int> sayi_listesi = new List<int>();
            string harf = "abcçdefgðhýijklmnoöprsþtuüvyz";
           
            
            
            for (int i = 0; i < 29; i++)
            {
                harf_listesi.Add(harf[i]);
                sayi_listesi.Add(0);
            }
            harf = richTextBox1.Text;
            harf=harf.ToLower();
            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < harf.Length; j++)
                {
                    if(harf_listesi[i] == harf[j])
                        sayi_listesi[i]++;
                }
            }

            //sayilar=sayi_listesi.ToString();
            for(int i = 0; i < 29; i++)
            {
                if(sayi_listesi[i] != 0)
                 listBox1.Items.Add(harf_listesi[i] + ":" + sayi_listesi[i]);
            }
            
        }
    }
}