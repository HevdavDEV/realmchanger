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

namespace Realm_Changer
{
    public partial class ServerInfoForm : Form
    {
        public ServerInfoForm()
        {
            InitializeComponent();
        }

        private void ServerInfoForm_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("ServerInfo.xml");
            XElement Realm = new XElement("Realm", new XElement("Name", textBox1.Text), new XElement("Realmlist", textBox2.Text));
            doc.Root.Add(Realm);
            doc.Save("ServerInfo.xml");
            this.Dispose();
            this.Close();
        }
    }
}
