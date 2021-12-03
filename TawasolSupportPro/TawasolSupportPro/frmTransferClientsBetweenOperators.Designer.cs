namespace TawasolSupportPro
{
    partial class frmTransferClientsBetweenOperators
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbllyoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.CboAllCurrentUsers = new System.Windows.Forms.ComboBox();
            this.chkLstBxClientsForUsers = new System.Windows.Forms.CheckedListBox();
            this.chkLstBxClientsForCurrentUser = new System.Windows.Forms.CheckedListBox();
            this.txtUserId_ToBeTransferTo = new System.Windows.Forms.TextBox();
            this.tblLayoutMoveButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnTransferAll = new System.Windows.Forms.Button();
            this.btnSingleTransfer = new System.Windows.Forms.Button();
            this.btnReturnBackAll = new System.Windows.Forms.Button();
            this.btnSingleReturnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbllyoutMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblLayoutMoveButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbllyoutMain
            // 
            this.tbllyoutMain.AutoSize = true;
            this.tbllyoutMain.ColumnCount = 1;
            this.tbllyoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllyoutMain.Controls.Add(this.lblTitle, 0, 0);
            this.tbllyoutMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tbllyoutMain.Controls.Add(this.btnClose, 0, 2);
            this.tbllyoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllyoutMain.Location = new System.Drawing.Point(0, 0);
            this.tbllyoutMain.Name = "tbllyoutMain";
            this.tbllyoutMain.RowCount = 3;
            this.tbllyoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbllyoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllyoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tbllyoutMain.Size = new System.Drawing.Size(412, 291);
            this.tbllyoutMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Clients Transfer";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.14498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.85502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CboAllCurrentUsers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkLstBxClientsForUsers, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkLstBxClientsForCurrentUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUserId_ToBeTransferTo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblLayoutMoveButtons, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 208);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentUser.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUser.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(126, 4);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "CurrentUser";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CboAllCurrentUsers
            // 
            this.CboAllCurrentUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CboAllCurrentUsers.FormattingEnabled = true;
            this.CboAllCurrentUsers.Location = new System.Drawing.Point(193, 3);
            this.CboAllCurrentUsers.Name = "CboAllCurrentUsers";
            this.CboAllCurrentUsers.Size = new System.Drawing.Size(210, 21);
            this.CboAllCurrentUsers.TabIndex = 1;
            this.CboAllCurrentUsers.SelectedIndexChanged += new System.EventHandler(this.CboAllCurrentUsers_SelectedIndexChanged);
            // 
            // chkLstBxClientsForUsers
            // 
            this.chkLstBxClientsForUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstBxClientsForUsers.FormattingEnabled = true;
            this.chkLstBxClientsForUsers.Location = new System.Drawing.Point(193, 7);
            this.chkLstBxClientsForUsers.Name = "chkLstBxClientsForUsers";
            this.chkLstBxClientsForUsers.Size = new System.Drawing.Size(210, 184);
            this.chkLstBxClientsForUsers.TabIndex = 3;
            // 
            // chkLstBxClientsForCurrentUser
            // 
            this.chkLstBxClientsForCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstBxClientsForCurrentUser.FormattingEnabled = true;
            this.chkLstBxClientsForCurrentUser.Location = new System.Drawing.Point(3, 7);
            this.chkLstBxClientsForCurrentUser.Name = "chkLstBxClientsForCurrentUser";
            this.chkLstBxClientsForCurrentUser.Size = new System.Drawing.Size(126, 184);
            this.chkLstBxClientsForCurrentUser.TabIndex = 5;
            // 
            // txtUserId_ToBeTransferTo
            // 
            this.txtUserId_ToBeTransferTo.Location = new System.Drawing.Point(135, 3);
            this.txtUserId_ToBeTransferTo.Name = "txtUserId_ToBeTransferTo";
            this.txtUserId_ToBeTransferTo.Size = new System.Drawing.Size(51, 20);
            this.txtUserId_ToBeTransferTo.TabIndex = 6;
            // 
            // tblLayoutMoveButtons
            // 
            this.tblLayoutMoveButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLayoutMoveButtons.ColumnCount = 1;
            this.tblLayoutMoveButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMoveButtons.Controls.Add(this.btnTransferAll, 0, 0);
            this.tblLayoutMoveButtons.Controls.Add(this.btnSingleTransfer, 0, 1);
            this.tblLayoutMoveButtons.Controls.Add(this.btnReturnBackAll, 0, 3);
            this.tblLayoutMoveButtons.Controls.Add(this.btnSingleReturnBack, 0, 2);
            this.tblLayoutMoveButtons.Location = new System.Drawing.Point(135, 38);
            this.tblLayoutMoveButtons.Name = "tblLayoutMoveButtons";
            this.tblLayoutMoveButtons.RowCount = 4;
            this.tblLayoutMoveButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tblLayoutMoveButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tblLayoutMoveButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayoutMoveButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblLayoutMoveButtons.Size = new System.Drawing.Size(51, 135);
            this.tblLayoutMoveButtons.TabIndex = 4;
            // 
            // btnTransferAll
            // 
            this.btnTransferAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTransferAll.Location = new System.Drawing.Point(3, 3);
            this.btnTransferAll.Name = "btnTransferAll";
            this.btnTransferAll.Size = new System.Drawing.Size(45, 21);
            this.btnTransferAll.TabIndex = 0;
            this.btnTransferAll.Text = ">>";
            this.btnTransferAll.UseVisualStyleBackColor = true;
            // 
            // btnSingleTransfer
            // 
            this.btnSingleTransfer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSingleTransfer.Location = new System.Drawing.Point(3, 30);
            this.btnSingleTransfer.Name = "btnSingleTransfer";
            this.btnSingleTransfer.Size = new System.Drawing.Size(45, 23);
            this.btnSingleTransfer.TabIndex = 1;
            this.btnSingleTransfer.Text = ">";
            this.btnSingleTransfer.UseVisualStyleBackColor = true;
            this.btnSingleTransfer.Click += new System.EventHandler(this.btnSingleTransfer_Click);
            // 
            // btnReturnBackAll
            // 
            this.btnReturnBackAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturnBackAll.Location = new System.Drawing.Point(3, 100);
            this.btnReturnBackAll.Name = "btnReturnBackAll";
            this.btnReturnBackAll.Size = new System.Drawing.Size(45, 23);
            this.btnReturnBackAll.TabIndex = 2;
            this.btnReturnBackAll.Text = "<<";
            this.btnReturnBackAll.UseVisualStyleBackColor = true;
            // 
            // btnSingleReturnBack
            // 
            this.btnSingleReturnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSingleReturnBack.Location = new System.Drawing.Point(3, 71);
            this.btnSingleReturnBack.Name = "btnSingleReturnBack";
            this.btnSingleReturnBack.Size = new System.Drawing.Size(45, 23);
            this.btnSingleReturnBack.TabIndex = 3;
            this.btnSingleReturnBack.Text = "<";
            this.btnSingleReturnBack.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(3, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTransferClientsBetweenOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 291);
            this.ControlBox = false;
            this.Controls.Add(this.tbllyoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransferClientsBetweenOperators";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Clients Between Operators";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmTransferClientsBetweenOperators_Load);
            this.tbllyoutMain.ResumeLayout(false);
            this.tbllyoutMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblLayoutMoveButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllyoutMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ComboBox CboAllCurrentUsers;
         
         private System.Windows.Forms.CheckedListBox chkLstBxClientsForUsers;
        private System.Windows.Forms.TableLayoutPanel tblLayoutMoveButtons;
        private System.Windows.Forms.Button btnTransferAll;
        private System.Windows.Forms.Button btnSingleTransfer;
        private System.Windows.Forms.Button btnReturnBackAll;
        private System.Windows.Forms.Button btnSingleReturnBack;
        private System.Windows.Forms.CheckedListBox chkLstBxClientsForCurrentUser;
        private System.Windows.Forms.TextBox txtUserId_ToBeTransferTo;
     }
}