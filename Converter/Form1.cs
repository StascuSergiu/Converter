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
            cbCUILength.DataSource = Constants.lengthVariantsForCUI;
        }

        private void btGenerateClick(object sender, EventArgs e)
        {
            var indexJudet = cbJudet.SelectedIndex + 1;
            tbCNP.Text = new CnpGenerator().GenerateCNP(datePickerDataNasterii.Value, indexJudet.ToString("00"), cbSex.Text);
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
            lblAgeValue.Text = DataParser.getAgeInTextFormat(datePickerDataNasterii.Value);
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

        private void btnCNPCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbCNP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la copierea CNP-ului");
            }
        }

        private void btnNumeCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbNume.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la copierea numelui");
            }
        }

        private void btnPrenumeCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbPrenume.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la copierea prenumelui");
            }
        }
    }
}