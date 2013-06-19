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
        }

        public ServerInfoForm()
        {
            InitializeComponent();
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
    }
}
