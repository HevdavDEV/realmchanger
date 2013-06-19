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
            if(System.IO.File.Exists("ServerInfo.xml"))
            {
                LoadXmlFile();
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
             *         <Name>Test</Name>
             *         <Realmlist>Test</Realmlist>
             *     </Realm>
             * <ServerInfo>
             */

            XmlDocument doc = new XmlDocument();
            doc.Load("ServerInfo.xml");
            XmlNodeList ServerNodes = doc.SelectNodes("ServerInfo/Realm/Name");
            foreach (XmlNode Name in ServerNodes)
            {
                //load relmalist as well, place is container
                comboBox1.Items.Add(Name.InnerText);
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
    }
}