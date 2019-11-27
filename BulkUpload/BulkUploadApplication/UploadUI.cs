using BulkUploadLogics.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using System.Configuration;
using System.IO;

namespace BulkUploadApplication
{
    public partial class UploadUI : Form
    {
        public UploadUI()
        {
            InitializeComponent();
        }
        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                if (SingleFile.Checked)
                {
                    var builder = ContainerConfigurator.Configure();
                    var container = builder.Build();

                    var call = container.Resolve<ISaveImage>();
                    if (call.PullImage())
                    {
                        MessageBox.Show("File uploaded succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Error in File Upload. Please try again.");
                    }
                }
                else
                {
                    var builder = ContainerConfigurator.Configure();
                    var container = builder.Build();

                    var call = container.Resolve<ISaveImage>();
                    try
                    {
                        call.PullAllImage();

                        MessageBox.Show("File uploaded succesfully");
                    }
                    catch
                    {
                        MessageBox.Show("Error in File Upload. Please try again.");
                    }

                }
            }
            catch(Exception exp)
            {
                string errorLog = ConfigurationManager.AppSettings["ErrorLog"];
                string errorLogFileName = errorLog + "_" + DateTime.Now.ToFileTime() + ".txt";
                File.AppendAllText(errorLogFileName, exp.StackTrace.ToString());
            }
       }            
    }
}
