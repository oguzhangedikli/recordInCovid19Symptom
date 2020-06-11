using System; //sistem kullanılır
using System.Collections.Generic; //sistemin genel koleksiyonlarını tanımlayan sınıflarını içerir.
using System.ComponentModel;//bileşenlerin ve tasarım zamanı davranışını uygulamak için kullanılan sınıfları sağlar.
using System.Data;//birden çok veri kaynağındanbileşenleri oluşturmanızı sağlar.
using System.Drawing;//grafiklere erişim sağlar
using System.Linq;//birden çok veri kümesine işlem yapılmasını sağlar
using System.Text;// bir ad alanında türlerin kullanımını sağlar
using System.Threading.Tasks;//zaman uyumsuz kod yazma işlemini kolay hale getirir.
using System.Windows.Forms;//form oluşturma

namespace belirtiKaydiProg //özelliklerin, sınıfların ve fonksiyonların bir yerde toplandığı yer
{
    public partial class Form1 : Form//formun yapısı
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SonucButton_Click(object sender, EventArgs e)//sonuçları göster butonunun içine giriyoruz.
        {
            sncIsımLabel.Text = "İsim"; //sncIsımLabel'a isim yazısını tanımlıyoruz
            sncSonucLabel.Text = "Sonuç"; //sncSonucLabel'a sonuç yazısını tanımlıyoruz
            sncSoyIsimLabel.Text = "Soy İsim"; //sncSoyIsimLabel'a soy isim yazısını tanımlıyoruz
            sncTcLabel.Text = "T.C. Numarası";//sncTcLabel'a tc numarası yazısını tanımlıyoruz
            sncTelefonLabel.Text = "Telefon";//sncTelefonLabel'a telefon yazısını tanımlıyoruz
            sncYasAraligiLabel.Text = "Yaş";//sncYaşAraligiLabel'a yaş yazısını tanımlıyoruz
            sncAdresLabel.Text = "Adres";//sncAdresLabel'a adres yazısını tanımlıyoruz
            sncikiNoktalabel1.Text = ":";//sncikiNoktalabel1'e : yazısını tanımlıyoruz
            sncikiNoktalabel2.Text = ":";//sncikiNoktalabel2'ye : yazısını tanımlıyoruz
            sncikiNoktalabel3.Text = ":";//sncikiNoktalabel3'e : yazısını tanımlıyoruz
            sncikiNoktalabel4.Text = ":";//sncikiNoktalabel4'e : yazısını tanımlıyoruz
            sncikiNoktalabel5.Text = ":";//sncikiNoktalabel5'e : yazısını tanımlıyoruz
            sncikiNoktalabel6.Text = ":";//sncikiNoktalabel6'ya : yazısını tanımlıyoruz
            sonAdresLabel.Text = AdresTextBox.Text;// adres değerinin AdresTextBoxdan alınacağı tanımlanır
            sonIsimLabel.Text = isimTextBox.Text;// isim  değerinin İsimTextBoxdan   alınacağı tanımlanır
            sonSoyIsimLabel.Text = SoyIsimTextBox.Text;//soyisim  değerinin SoyIsimTextBoxdan  alınacağı tanımlanır
            sonTcLabel.Text = TcTextBox.Text;// tc numarasının değerinin TcTextBoxdan  alınacağı tanımlanır
            sonTelefonLabel.Text = TelefonTextBox.Text;// telefon numarasının  değerinin TelefonTextBoxdan  alınacağı tanımlanır
            sonYasAraligiLabel.Text = yasAraligiTextBox.Text;// yaşın değerinin yasAraligiTextBoxdan  alınacağı tanımlanır
            if (semptomCheckedListBox.CheckedItems.Count >= 2)//semptom ListBoxunda seçili itemler 2 ya da 2den fazlaysa bu yapıyı kullanırız.
            {
                if (semptomCheckedListBox.CheckedItems.Count >= 2 & arasiRadioButton2.Checked || uzeriRadioButton.Checked) //semptom ListBoxunda seçili itemler 2 ya da 2den fazlaysa ve yüksek ateş itemleri seçiliyse bu yapıyı kullanırız.
                {
                    sonAnalizLabel.Text = "Belirtilerinizden Dolayı ve\nYüksek Ateşiniz Sebebiyle\nDoktora Görünmelisiniz.";//ateş ve semptom durumlarının ikisi de  sağlanırsa sonuç kısmında bu metini yazdırıyoruz.
                }
                else if (semptomCheckedListBox.CheckedItems.Count >= 2 & altiRadioButton.Checked)//semptom ListBoxunda seçili itemler 2 ya da 2den fazlaysa ve düşük ateş itemi seçiliyse bu yapıyı kullanırız.
                {
                    sonAnalizLabel.Text = "Ateşinizin Yükselmesi\nDurumunda\nDoktora Görününüz"; //sadece semptom durumu sağlanırsa sonuç kısmında bu metini yazdırıyoruz.
                }

            }
            if (semptomCheckedListBox.CheckedItems.Count <= 1)//semptom ListBoxunda seçili itemler 1 ya da 1den az ise bu yapıyı kullanırız.
            {
                if (semptomCheckedListBox.CheckedItems.Count <= 1 & arasiRadioButton2.Checked || uzeriRadioButton.Checked)//semptom ListBoxunda seçili itemler 1 ya da 1den az ise ve yüksek ateş itemleri seçiliyse bu yapıyı kullanırız.
                {
                    sonAnalizLabel.Text = "Semptomların Görülmesi\nDurumunda\nDoktora Görününüz";//sadece ateş durumu sağlanırsa sonuç kısmında bu metini yazdırıyoruz.
                }

                else if (semptomCheckedListBox.CheckedItems.Count <= 1 & altiRadioButton.Checked)//semptom ListBoxunda seçili itemler 1 ya da 1den az ise ve düşük ateş itemi seçiliyse bu yapıyı kullanırız.
                {

                sonAnalizLabel.Text = "Virüs Taşıma Olasılığınız\nDüşüktür.";//ateş ve semptom durumlarının ikisi de sağlanmazsa sonuç kısmında bu metini yazdırıyoruz.
                }
            }

        }

        private void bagisiklikButton_Click(object sender, EventArgs e) //maddeleri göstermek için oluşturulan buton
        {
            bagisiklikListBox.Items.Add("Güçlü Bağışıklık Sistemi için Yeterli ve Dengeli Beslenin, Kaliteli Uyku Uyuyun ve Egzersiz Yapın.");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("Çeşitli ve Rengarenk Beslenin");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("D Vitaminin En Önemli Kaynağı Güneş.");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("Günde Bir Avuç Ceviz, Fındık, Badem gibi Yağlı Tohumlar Bağışıklık Sisteminin Güçlenmesine Katkı Sağlıyor");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("Yeterli ve Dengeli Beslenme, Tüm Besin Gruplarına Günlük Beslenmede Yer Vermekle Mümkün.");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("Bir Küçük Boy Patates Günlük A Vitamini İhtiyacını Karşılıyor.");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("Vücutta Gerçekleşen Çoğu Reaksiyon İçin Su Gereklidir.");//listboxa yazılacak maddeleri ekliyoruz
            bagisiklikListBox.Items.Add("Balık Tüketimi Arttırılmalıdır.");

            bagisiklikListBox.BackColor = Color.LimeGreen;//listboxun arka planı lime green olarak ayarlanır.
        }

        private void temizleButton_Click(object sender, EventArgs e)//kayıtları temizlemek için oluşturulan buton
        {
            {
                foreach (Control item in this.Controls)//kayıt temizlemek için bu yapıyı kullanacağız

                {

                    if (item is TextBox)

                    {

                        TextBox tbox = (TextBox)item;

                        tbox.Clear();//textlerdeki kaydın foreach kullanılarak silinmesi

                    }

                }
                {
                    while (semptomCheckedListBox.CheckedIndices.Count > 0)
                        semptomCheckedListBox.SetItemChecked(semptomCheckedListBox.CheckedIndices[0], false);// semptom listboxunda 1 ve 1 den fazla item işaretliyse temizlenmesini sağlıyoruz
                }

                altiRadioButton.Checked = false; //RadioButtondaki kaydın false kullanılarak temizlenmesi
                uzeriRadioButton.Checked = false; //RadioButtondaki kaydın false kullanılarak temizlenmesi
                arasiRadioButton2.Checked = false; //RadioButtondaki kaydın fale kullanılarak temizlenmesi
                sonAnalizLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi                   
                sonAdresLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi 
                sonIsimLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi 
                sonSoyIsimLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi 
                sonTcLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi 
                sonTelefonLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi 
                sonYasAraligiLabel.Text = ""; // labeldaki kaydın  “ ” kullanılarak silinmesi 
                bagisiklikListBox.Items.Clear(); //listboxdaki kaydın silinmesi
                bagisiklikListBox.BackColor = Color.White; //listboxun arkaplan renginin belirlenmesi


            }
        }

       

        }
    }
