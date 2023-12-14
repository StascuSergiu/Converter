using Newtonsoft.Json;
using System.Reflection.Metadata;

namespace Converter
{
    public partial class Form1 : Form
    {
        List<string> sex = new List<string>();
        List<string> prenumeM = new List<string>();
        List<string> prenumeF = new List<string>();
        List<string> nume = new List<string>();
        public List<string> CUILength = new List<string>()
        {
            "10","9","8","7","6","5","4","3","2"
        };

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
            cbCUILength.DataSource = CUILength;
        }

        private void btGenerateClick(object sender, EventArgs e)
        {
            var indexJudet = cbJudet.SelectedIndex + 1;
            tbCNP.Text = new CnpGenerator().GenerateCNP(dateTimePicker1.Value, indexJudet.ToString("00"), cbSex.Text);
            var random = new Random();
            tbPrenume.Text = cbSex.Text == "M" ? prenumeM[random.Next(prenumeM.Count)] : prenumeF[random.Next(prenumeF.Count)];
            tbNume.Text = nume[random.Next(nume.Count)];
            tbCui.Text = new CUIGenerator().GeneratorCUI(int.Parse(cbCUILength.Text));
        }

        private void btnCopySuoId_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbDbFormat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la copierea SupervisionId-ului");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var age = DateTime.Now - dateTimePicker1.Value;
            var year = age.Days / 365;
            var month = (age.Days - (year * 365)) / 30;
            var days = age.Days - (year * 365) - (month * 30);
            lblAgeValue.Text = $"{year} ani, {month} luni, {days} zile";
        }

        private void btnCopyCUI_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbCui.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la copierea CUI-ului");
            }
        }
    }
}