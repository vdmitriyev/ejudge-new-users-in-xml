using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace CreateXMLWithNewEjudgeUsers
{
    public partial class MainForm : Form
    {
        ProcessDataToXML pd = new ProcessDataToXML();        

        public MainForm(){

            InitializeComponent();
            setDefaultValues();
        }

        private void setDefaultValues(){

            this.txtPathToXML.Text = pd.pathToXML;
            this.txtPathToCSV.Text = pd.pathToCSV;
            this.txtPathToPrintFile.Text = pd.pathToPrintFile;
        }


        
        private void MainForm_Load(object sender, EventArgs e){

        }

        private void btnGenerateNewUsers_Click(object sender, EventArgs e)
        {
            
            pd.pathToXML = this.txtPathToXML.Text;
            pd.pathToCSV = this.txtPathToCSV.Text;
            pd.pathToPrintFile = this.txtPathToPrintFile.Text;

            pd.startEjudgeID = int.Parse(txtEjudgeStartID.Text);
            pd.startLoginNumber = int.Parse(txtEjudgeLoginStartNumber.Text);
            pd.ejudgeLoginPrefix = txtEjudgeLoginPrefix.Text;

            //parseCSV();
            pd.parseCSVWithShoolAndCity();
            //generateNewLogins();
            pd.generateNewLoginsWithSchoolAndCity();
            MessageBox.Show("Please check following files : " + "\n\n"
                             + "1." + this.txtPathToPrintFile.Text + "\n\n"
                             + "2." + this.txtPathToXML.Text + "\n"
                             );
        }

    }
}
