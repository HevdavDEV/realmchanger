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
using System.IO;

namespace Realm_Changer
{
    public partial class ServerInfoForm : Form
    {
        public ServerInfoForm(string name, string realmlist)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text = realmlist;
            this.name = name;
            this.realmlist = realmlist;
            EditRealmButton.Visible = true;
        }

        public ServerInfoForm()
        {
            InitializeComponent();
            AddRealmButton.Visible = true;
        }

        private void ServerInfoForm_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument doc = XDocument.Load("ServerInfo.xml");
                XElement Realm = new XElement("Realm", new XElement("Name", textBox1.Text), new XElement("Realmlist", textBox2.Text));
                doc.Root.Add(Realm);
                doc.Save("ServerInfo.xml");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("no");
            }
            
            this.Dispose();
            this.Close();
        }

        private void EditRealmButton_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ServerInfo.xml");
            string namepath = "ServerInfo/Realm[Name='" + this.name + "']";
            string realmlistpath = "ServerInfo/Realm[Realmlist='" + this.realmlist + "']";
            XmlNode _name = doc.SelectSingleNode(namepath);
            XmlNode _realmlist = doc.SelectSingleNode(realmlistpath);
            if (textBox1.Text != _name.FirstChild.InnerText)
                _name.FirstChild.InnerText = textBox1.Text;
            if (textBox2.Text != _realmlist.LastChild.InnerText)
                _realmlist.LastChild.InnerText = textBox2.Text;
            doc.Save("ServerInfo.xml");
            MainForm ReloadProgram = new MainForm();
            ReloadProgram.LoadXmlFile();
            this.Dispose();
            this.Close();
        }

        private string name;
        private string realmlist;
    }
}
