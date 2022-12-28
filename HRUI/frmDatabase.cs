using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.CodeDom;

using HRCore.Entity;
using HRCore.Util;

namespace AntsUI
{
    public partial class frmDatabase : Form
    {
        public Server Server { get; set; }
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            Localize();

            Server server = ServerHelper.Load(Program.global.G_ConfigFile_Server, online);
            if (server == null)
            {
                txtHost.Text = "10.15.2.98";
                txtPort.Text = "5432";
                txtDatabase.Text = "ate2020";
                txtUserID.Text = "postgres";
                txtPassword.Text = "Blueway123456";
                chkOnline.Checked = true;
            }
            else
            {
                txtHost.Text = server.Host;
                txtPort.Text = server.Port;
                txtDatabase.Text = server.DatabaseName;
                txtUserID.Text = server.DatabaseUserID;
                txtPassword.Text = server.GetPassword();
                chkOnline.Checked = server.Online;
            }
            btnTesting.Click += ConnectionTesting;
            btnOK.Click += Save;
            btnCancel.Click += Close;
        }

        private void Localize()
        {
            

        }

        private void ConnectionTesting(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //throw new NotImplementedException();
            using (Server db = new Server()
            {
                Host = txtHost.Text,
                Port = txtPort.Text,
                DatabaseName = txtDatabase.Text,
                DatabaseUserID = txtUserID.Text,
            })
            {
                db.SetPassword(txtPassword.Text);
                try
                {
                    db.Open();
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(Resources.__TestingSuccessfully, Resources.PromptInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(Resources.__TestingFailed + System.Environment.NewLine + ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Save(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Server = new Server();
            Server.Online = chkOnline.Checked;
            Server.Host = txtHost.Text;
            Server.Port = txtPort.Text;
            Server.DatabaseName = txtDatabase.Text;
            Server.DatabaseUserID = txtUserID.Text;
            Server.SetPassword(txtPassword.Text);
            Server.ApplicationName = Program.global.G_ApplicationName;

            //if (ServerHelper.Save(AntsUI.Program.global.G_ConfigFile_Server, Server))
            if (ServerHelper.Save(Program.global.G_ConfigFile_Server, Server))
            {
                Close();
                //MessageBox.Show("数据库设置成功！请重新登录！", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show($"{ Resources.__SetSuccessfully } { Resources.__PleaseLoginAgain }", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                //Application.Exit();
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    Form frm = Application.OpenForms[i];
                    frm.Close();
                }
                Application.Exit();
            }
            else
            {
                MessageBox.Show(Resources.__FileSaveFailed, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Close(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.Dispose();
            this.Close();
        }

    }
}
