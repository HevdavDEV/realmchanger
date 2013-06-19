using System;
using System.Configuration;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Web;

namespace Realm_Changer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("ServerInfo.xml"))
            {
                LoadXmlFile();
            }
            else
            {
                //create xml file faggot
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adds server
            ServerInfoForm InfoForm = new ServerInfoForm();
            InfoForm.ShowDialog();
            comboBox1.Items.Clear();
            LoadXmlFile();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServerInfoForm EditForm = new ServerInfoForm(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
                EditForm.ShowDialog();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void LoadXmlFile()
        {
            /*
             * <ServerInfo>
             *     <Realm>
             *         <Name></Name>
             *         <Realmlist></Realmlist>
             *     </Realm>
             * <ServerInfo>
             */

            XmlDocument doc = new XmlDocument();
            doc.Load("ServerInfo.xml");
            XmlNodeList RealmNodes = doc.SelectNodes("//Realm");
            XmlNodeList RealmlistNodes = doc.SelectNodes("//Realmlist");
            List<String> Realmlist = new List<String>();
            List<String> Realms = new List<String>();

            foreach(XmlNode temp_realmlist in RealmlistNodes)
            {
                Realmlist.Add(temp_realmlist.Value.ToString());
            }

            foreach (XmlNode Realm in RealmNodes)
            {
                Realms.Add(Realm.Value.ToString());
            }

            for (int i = 0; i < Realms.Count(); i++)
            {
                ComboBoxList.Add(Realms[i], Realmlist[i]);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //delete button
            XmlDocument doc = new XmlDocument();
            doc.Load("ServerInfo.xml");
            try
            {
                string path = "ServerInfo/Realm[Name='" + comboBox1.SelectedItem.ToString() + "']";
                XmlNode node = doc.SelectSingleNode(path);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Server not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //refresh combobox
            comboBox1.Items.Clear();
            LoadXmlFile();
        }

        private Dictionary<String, String> ComboBoxList;
    }
}