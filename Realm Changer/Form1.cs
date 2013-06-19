﻿using System;
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
using System.IO;

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
                XElement Realm = new XElement("ServerInfo");
                XDocument doc = new XDocument(Realm);
                XElement test = new XElement("Realm", new XElement("Name", "Example"), new XElement("Realmlist", "Example"));
                doc.Root.Add(test);
                doc.Save("ServerInfo.xml");
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
                MessageBox.Show("No server selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ServerInfo.xml");
                XmlNodeList RealmNodes = doc.SelectNodes("Name");
                XmlNodeList RealmlistNodes = doc.SelectNodes("Realmlist");
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
            catch(FileNotFoundException)
            {
                //create xml file
                File.Create("ServerInfo.xml");
                MessageBox.Show("XML File doesn't exist, add a realm first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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