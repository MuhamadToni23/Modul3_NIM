namespace Modul3_NIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // 1. Validasi: Cek apakah ComboBox sudah dipilih
            if (comboBoxAsal.SelectedItem == null || comboBoxTujuan.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            // 2. Validasi: Cek apakah input angka valid
            if (string.IsNullOrWhiteSpace(txtNilaiAwal.Text) || !double.TryParse(txtNilaiAwal.Text, out double inputSuhu))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string asal = comboBoxAsal.SelectedItem.ToString();
            string tujuan = comboBoxTujuan.SelectedItem.ToString();
            double hasil = 0;

            // 3. Logika Konversi (Standarisasi ke Celcius dulu agar lebih mudah)
            double celcius = 0;

            // Konversi dari Asal ke Celcius
            switch (asal)
            {
                case "Celcius": celcius = inputSuhu; break;
                case "Fahrenheit": celcius = (inputSuhu - 32) * 5 / 9; break;
                case "Kelvin": celcius = inputSuhu - 273.15; break;
                case "Reamur": celcius = inputSuhu * 5 / 4; break;
            }

            // Konversi dari Celcius ke Tujuan
            switch (tujuan)
            {
                case "Celcius": hasil = celcius; break;
                case "Fahrenheit": hasil = (celcius * 9 / 5) + 32; break;
                case "Kelvin": hasil = celcius + 273.15; break;
                case "Reamur": hasil = celcius * 4 / 5; break;
            }

            // Tampilkan hasil
            txtNilaiAkhir.Text = hasil.ToString("N2"); // N2 untuk 2 angka di belakang koma
        }
    }
}