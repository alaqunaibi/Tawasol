using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using TawasolSupportPro.Tawasol_Service  ;
using System.Data ;
using System.Xml;
using System.Xml.Serialization;
using System.Threading ;
using System.IO;


 namespace TawasolSupportPro
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.TextBox txtUserPwd;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.TextBox txtCustomerPwd;
        private System.Windows.Forms.Label label5;
        private IContainer components;

        private Utilities Util;

		public frmLogin()
		{
            
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            Util = new Utilities();

        
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCustomerPwd = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserPwd = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 32);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qunaibi Systematic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.txtCustomerPwd);
            this.panel2.Controls.Add(this.txtUserID);
            this.panel2.Controls.Add(this.txtUserPwd);
            this.panel2.Controls.Add(this.txtCustomerID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(208, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 198);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCustomerPwd
            // 
            this.txtCustomerPwd.BackColor = System.Drawing.Color.White;
            this.txtCustomerPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPwd.Location = new System.Drawing.Point(16, 50);
            this.txtCustomerPwd.Name = "txtCustomerPwd";
            this.txtCustomerPwd.PasswordChar = '*';
            this.txtCustomerPwd.Size = new System.Drawing.Size(200, 26);
            this.txtCustomerPwd.TabIndex = 1;
            this.txtCustomerPwd.TextChanged += new System.EventHandler(this.txtCustomerPwd_TextChanged);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(16, 107);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(200, 26);
            this.txtUserID.TabIndex = 2;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged);
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.BackColor = System.Drawing.Color.White;
            this.txtUserPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPwd.Location = new System.Drawing.Point(16, 147);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(200, 26);
            this.txtUserPwd.TabIndex = 3;
            this.txtUserPwd.TextChanged += new System.EventHandler(this.txtUserPwd_TextChanged);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(16, 10);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 26);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 198);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Company Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "UserID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 48);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(232, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(120, 8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(456, 278);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}
		
		void SerializeDataSet(DataSet Result)
		{
				XmlSerializer ser = new XmlSerializer(typeof(DataSet));
				TextWriter writer = new StreamWriter("d:\\SupportInfo.xml");
				ser.Serialize(writer, Result);
				writer.Close();
		}


       

        private bool checkValidLogin()
        { 
                 if (btnLogin.DialogResult == DialogResult.OK && (txtCustomerID.Text == String.Empty || txtCustomerPwd.Text == String.Empty || txtUserID.Text == String.Empty || txtUserPwd.Text == String.Empty))
                    {
                      MessageBox.Show("Please Enter Your Login Info.");
                      return false;
                    }
                 else
                     return true;

        }


        private void Logining()
        { 
             Tawasol_WService_CLS Tawasol = new Tawasol_WService_CLS();
             DataSet Result = new DataSet();
             Result = Tawasol.CheckLogin(txtUserID.Text, txtUserPwd.Text, txtCustomerID.Text, txtCustomerPwd.Text);



            if (Result.Tables.Count > 0)
            {
                if (Result.Tables[0].Rows.Count > 0)
                {

                    if (btnLogin.DialogResult == DialogResult.OK)
                    {
                        Util.SerializeDataSet(Result);

                        //SerializeDataSet(RSerializeDataSetesult);
                        Form1 frm = new Form1();
                        frm.Show();
                         frm.Owner = this;

                        txtUserID.Text= txtUserPwd.Text= txtCustomerID.Text= txtCustomerPwd.Text=string.Empty ;
                        this.Refresh();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry,You have not Permission to Navigate");
                }
            }
        }

            
		private void btnLogin_Click(object sender, System.EventArgs e)
		{

            if (checkValidLogin())
            {
                Logining();
            }

		}

		private void panel4_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void txtCustomerPwd_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void panel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
            txtUserID.BackColor = Color.Wheat; 
			this.Close();
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void panel1_Paint_1(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void txtCustomerID_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtUserPwd_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtUserID_TextChanged(object sender, System.EventArgs e)
		{
		
		}

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnClose.DialogResult = DialogResult.Cancel;
            btnLogin.DialogResult = DialogResult.OK;

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLogin.DialogResult == DialogResult.OK && (txtCustomerID.Text == String.Empty || txtCustomerPwd.Text == String.Empty || txtUserID.Text == String.Empty || txtUserPwd.Text == String.Empty))
            {
                if (txtUserID.BackColor != Color.Wheat)
                {
                e.Cancel = true;
                
                MessageBox.Show("Please Enter Your Login Info.");
                }

            }
        }
	}
}
