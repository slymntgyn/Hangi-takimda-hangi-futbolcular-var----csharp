using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
namespace futbolcular
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string takimadi = comboBox1.SelectedItem.ToString();

            string connection = "https://api.livescorexml.com/?user=demo&password=123456&get=squads&id=196&type=area";

            Oyuncular.Items.Clear();
            XDocument p = XDocument.Load(connection);
            if (comboBox1.SelectedItem == "Trabzonspor")
            {
                for (int i = 0; i < 36; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Beşiktaş")
            {
                for (int i = 36; i < 75; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Gaziantepspor")
            {
                for (int i = 75; i < 81; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Galatasaray")
            {
                for (int i = 81; i < 113; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Gençlerbirliği")
            {
                for (int i = 113; i < 147; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Malatyaspor")
            {
                for (int i = 147; i < 148; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Fenerbahçe")
            {
                for (int i = 148; i < 184; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Denizlispor")
            {
                for (int i = 184; i < 224; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Ankaragücü")
            {
                for (int i = 224; i < 260; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Samsunspor")
            {
                for (int i = 260; i < 298; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Diyarbakırspor")
            {
                for (int i = 298; i < 330; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Konyaspor")
            {
                for (int i = 330; i < 362; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Çaykur Rizespor")
            {
                for (int i = 362; i < 393; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Akçaabat Sebatspor")
            {
                for (int i = 393; i < 395; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "İstanbulspor")
            {
                for (int i = 395; i < 435; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Bursaspor")
            {
                for (int i = 435; i < 464; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Elazığspor")
            {
                for (int i = 464; i < 492; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }

            else if (comboBox1.SelectedItem == "Adanaspor")
            {
                for (int i = 492; i < 526; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Kocaelispor")
            {
                for (int i = 526; i < 552; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Altay")
            {
                for (int i = 552; i < 585; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Göztepe")
            {
                for (int i = 585; i < 616; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Antalyaspor")
            {
                for (int i = 616; i < 654; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Sakaryaspor")
            {
                for (int i = 654; i < 685; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Çanakkale Dardanelspor")
            {
                for (int i = 685; i < 690; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Karabükspor")
            {
                for (int i = 690; i < 721; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Kayseri Erciyesspor")
            {
                for (int i = 721; i < 735; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Akyurt Şekerspor")
            {
                for (int i = 735; i < 738; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Sarıyer")
            {
                for (int i = 738; i < 774; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            else if (comboBox1.SelectedItem == "Karşıyaka")
            {
                for (int i = 774; i < 804; i++)
                {
                    var adi = p.Descendants("person").ElementAt(i).Attribute("name").Value;
                    var tipi = p.Descendants("person").ElementAt(i).Attribute("type").Value;
                    var mevki = p.Descendants("person").ElementAt(i).Attribute("position").Value;
                    Oyuncular.Items.Add(adi + " isimli " + tipi + " " + takimadi + " takımında " + mevki + " mevkisinde oyamaktadır.");
                }
            }
            /******************************************************/
            if (comboBox1.SelectedItem == "Trabzonspor")
            {
                pictureBox2.ImageLocation = "Trabzonspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Beşiktaş")
            {
                pictureBox2.ImageLocation = "Beşiktaş.jpg";
            }
            else if (comboBox1.SelectedItem == "Gaziantepspor")
            {
                pictureBox2.ImageLocation = "Gaziantepspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Galatasaray")
            {
                pictureBox2.ImageLocation = "Galatasaray.jpg";
            }
            else if (comboBox1.SelectedItem == "Gençlerbirliği")
            {
                pictureBox2.ImageLocation = "Gençlerbirliği.jpg";
            }
            else if (comboBox1.SelectedItem == "Malatyaspor")
            {
                pictureBox2.ImageLocation = "Malatyaspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Fenerbahçe")
            {
                pictureBox2.ImageLocation = "Fenerbahçe.jpg";
            }
            else if (comboBox1.SelectedItem == "Denizlispor")
            {
                pictureBox2.ImageLocation = "Denizlispor.jpg";
            }
            else if (comboBox1.SelectedItem == "Ankaragücü")
            {
                pictureBox2.ImageLocation = "Ankaragücü.jpg";
            }
            else if (comboBox1.SelectedItem == "Samsunspor")
            {
                pictureBox2.ImageLocation = "Samsunspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Diyarbakırspor")
            {
                pictureBox2.ImageLocation = "Diyarbakırspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Konyaspor")
            {
                pictureBox2.ImageLocation = "Konyaspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Çaykur Rizespor")
            {
                pictureBox2.ImageLocation = "Çaykur Rizespor.jpg";
            }
            else if (comboBox1.SelectedItem == "Akçaabat Sebatspor")
            {
                pictureBox2.ImageLocation = "Akçaabat Sebatspor.jpg";
            }
            else if (comboBox1.SelectedItem == "İstanbulspor")
            {
                pictureBox2.ImageLocation = "İstanbulspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Bursaspor")
            {
                pictureBox2.ImageLocation = "Bursaspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Elazığspor")
            {
                pictureBox2.ImageLocation = "Elazığspor.jpg";
            }

            else if (comboBox1.SelectedItem == "Adanaspor")
            {
                pictureBox2.ImageLocation = "Adanaspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Kocaelispor")
            {
                pictureBox2.ImageLocation = "Kocaelispor.jpg";
            }
            else if (comboBox1.SelectedItem == "Altay")
            {
                pictureBox2.ImageLocation = "Altay.jpg";
            }
            else if (comboBox1.SelectedItem == "Göztepe")
            {
                pictureBox2.ImageLocation = "Göztepe.jpg";
            }
            else if (comboBox1.SelectedItem == "Antalyaspor")
            {
                pictureBox2.ImageLocation = "Antalyaspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Sakaryaspor")
            {
                pictureBox2.ImageLocation = "Sakaryaspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Çanakkale Dardanelspor")
            {
                pictureBox2.ImageLocation = "Çanakkale Dardanelspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Karabükspor")
            {
                pictureBox2.ImageLocation = "Karabükspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Kayseri Erciyesspor")
            {
                pictureBox2.ImageLocation = "Kayseri Erciyesspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Akyurt Şekerspor")
            {
                pictureBox2.ImageLocation = "Akyurt Şekerspor.jpg";
            }
            else if (comboBox1.SelectedItem == "Sarıyer")
            {
                pictureBox2.ImageLocation = "Sarıyer.jpg";
            }
            else if (comboBox1.SelectedItem == "Karşıyaka")
            {
                pictureBox2.ImageLocation = "Karşıyaka.jpg";
            }
        }


        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

