using Newtonsoft.Json;

namespace Converter
{
    public partial class Form1 : Form
    {
        List<string> sex = new List<string>();
        List<string> prenumeM = new List<string>();
        List<string> prenumeF = new List<string>();
        List<string> nume = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            tbDbFormat.Text = tbUUID.Text.Replace("-", "").ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbJudet.DataSource = DataParser.GetJudete();
            sex.Add("M");
            sex.Add("F");
            cbSex.DataSource = sex;
            prenumeM = DataParser.GetPrenumeMasculin();
            prenumeF = DataParser.GetPrenumeFeminin();
            nume = DataParser.GetNume();
        }

        private void btGenerateClick(object sender, EventArgs e)
        {
            var indexJudet = cbJudet.SelectedIndex + 1;
            tbCNP.Text = new CnpGenerator().GenerateCNP(dateTimePicker1.Value, indexJudet.ToString("00"), cbSex.Text);
            var random = new Random();
            tbPrenume.Text = cbSex.Text == "M" ? prenumeM[random.Next(prenumeM.Count)] : prenumeF[random.Next(prenumeF.Count)];
            tbNume.Text = nume[random.Next(nume.Count)];
        }
    }
}