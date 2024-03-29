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
            if (File.Exists("Wow.exe"))
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
            else
            {
                MessageBox.Show("Place application in your WoW directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
                this.Close();
            }
        }

        private void AddServerButton_Click(object sender, EventArgs e)
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
                ServerInfoForm EditForm = new ServerInfoForm(comboBox1.SelectedItem.ToString(), ComboBoxList[comboBox1.SelectedItem.ToString()]);
                EditForm.ShowDialog();
                LoadXmlFile();
                comboBox1.Refresh();
                comboBox1.ResetText();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No server selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadXmlFile()
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
                XmlNodeList RealmNodes = doc.SelectNodes("ServerInfo/Realm/Name");
                XmlNodeList RealmlistNodes = doc.SelectNodes("ServerInfo/Realm/Realmlist");
                List<string> Realmlist = new List<string>();
                List<string> Realms = new List<string>();
                
                if (ComboBoxList.Count > 0)
                    ComboBoxList.Clear();

                foreach(XmlNode temp_realmlist in RealmlistNodes)
                {
                    Realmlist.Add(temp_realmlist.InnerText);
                }

                foreach (XmlNode Realm in RealmNodes)
                {
                    Realms.Add(Realm.InnerText);
                }

                for (int i = 0; i < Realms.Count(); i++)
                {
                    try
                    {
                        ComboBoxList.Add(Realms[i], Realmlist[i]);
                    }
                    catch (ArgumentException)
                    {
                    }
                }

                if (comboBox1.Items.Count > 0)
                    comboBox1.Items.Clear();

                foreach (KeyValuePair<string, string> entry in ComboBoxList)
                {
                    comboBox1.Items.Add(entry.Key);
                }
            
            }
            catch(FileNotFoundException)
            {
                //create xml file
                File.Create("ServerInfo.xml");
                MessageBox.Show("XML File doesn't exist, add a realm first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveServerButton_Click(object sender, EventArgs e)
        {
            //delete button
            
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ServerInfo.xml");
                string path = "ServerInfo/Realm[Name='" + comboBox1.SelectedItem.ToString() + "']";
                XmlNode node = doc.SelectSingleNode(path);
                node.ParentNode.RemoveChild(node);
                doc.Save("ServerInfo.xml");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Server not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadXmlFile();
            comboBox1.ResetText();
            comboBox1.Refresh();
        }

        private void LaunchGameButton_Click(object sender, EventArgs e)
        {
            //find realmlist for key
            string realmlist = "Set realmlist " + ComboBoxList[comboBox1.SelectedItem.ToString()];
            //set realmlist
            StreamWriter openFile = new StreamWriter("Data/realmlist.wtf");
            openFile.WriteLine(realmlist);
            openFile.Close();
            //launch game
            System.Diagnostics.Process.Start("Wow.exe");
        }

        private Dictionary<string, string> ComboBoxList = new Dictionary<string,string>();

        
    }
}