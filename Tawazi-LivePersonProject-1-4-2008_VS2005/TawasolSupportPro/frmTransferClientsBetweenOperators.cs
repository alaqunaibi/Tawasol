using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TawasolSupportPro.ConnectionService;
using System.Xml.Serialization;
using System.IO;
 
namespace TawasolSupportPro
{
    public partial class frmTransferClientsBetweenOperators : Form
    {

        public DataSet DataSetInfo;
        internal DataSet DsClientsALLUsers;
        internal  string CustomerId;
        internal  string UserId;
        public DataSet DsClientsForCurrentUser;
        internal DataSet DsClientsForSpecifiedUser;
        internal Tawasol_Service Tawsol;

        enum StatusClient
        {
            Client_Pending = 0,
            Client_Chatting = 1, //Hnadle  same
            Client_Block = 2,
            Client_Close = 3
        };

        enum ToTransfer
        {
            Waiting = 0,
            Accept = 1,
            Reject = 2

        };

        public frmTransferClientsBetweenOperators()
        {
            InitializeComponent();
         }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected bool CheckDataSet(DataSet chkds)
        {
            bool rtres = false;

            if (chkds.Tables.Count > 0)
            {
                if (chkds.Tables[0].Rows.Count > 0 && chkds.Tables[0].Columns.Count > 0)
                {
                    if (chkds.Tables[0].Rows[0][0].ToString() != string.Empty)
                    {
                        rtres = true;
                    }

                }
            }
            return rtres;
        }

        protected void FillComboBox(ComboBox   cmbox, DataSet ds)
        {
            foreach (DataRow Dr in ds.Tables[0].Rows)
            {
                cmbox.Items.Add(Dr["UserName"].ToString());
            }
         }


        protected void FillCheckListBox(CheckedListBox  chkBox, DataSet ds)
        {
            foreach (DataRow Dr in ds.Tables[0].Rows)
            {
                chkBox.Items.Add(Dr["ClientName"].ToString());
 
            }

        }

        //The following Function used to fill CurrentUser CheckList and Specified User 
        private void FillCurrentClientsForCurrentUser(string CustomerId, string UserId, string Status,CheckedListBox  chklist,ref DataSet ds)
        {
              
                /* status values
                 WHEN 0 THEN 'In Queue' 
                WHEN 1 THEN 'Chatting' 
                WHEN 2 THEN 'Block' 
                WHEN 3 THEN 'Out'
                 */

             ds = Tawsol.RetreiveData_FromProcedure("RetreiveClientsInfoForSpecifiedUser", "@CustomerId,@UserId,@Status","int,int,int", CustomerId + ',' + UserId + ',' + Status, string.Empty);

            if (CheckDataSet(ds))
            {
                FillCheckListBox(chklist, ds);

            }
        }


        private void FillAllUsers(string CustomerId, string UserId, string Status, CheckedListBox chklist)
        {
            Tawasol_Service Tawsol = new Tawasol_Service();
            DsClientsALLUsers = new DataSet();

            
            string Colstr="UserId,UserName,sectionId";
            string whrstr = "CustomerId=" + CustomerId +" and UserId!=" + UserId;


            DsClientsALLUsers = Tawsol.RetrieveData("tblUsers", Colstr, whrstr, string.Empty);


            if (CheckDataSet(DsClientsALLUsers))
            {
                FillComboBox(CboAllCurrentUsers, DsClientsALLUsers);

            }
        }


        private void frmTransferClientsBetweenOperators_Load(object sender, EventArgs e)
        {
            Tawsol = new Tawasol_Service();

            DsClientsForCurrentUser = new DataSet();
            DsClientsForSpecifiedUser = new DataSet();

            // Here We consider Satus is All Client in Chatting Only
            
            string Status = ((int)StatusClient.Client_Chatting).ToString();

            Utilities util = new Utilities();
            util.DeserializeDataSet(ref DataSetInfo);

            CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();
            UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();
            lblCurrentUser.Text = DataSetInfo.Tables[0].Rows[0]["UserName"].ToString();
             

            FillCurrentClientsForCurrentUser(CustomerId, UserId, Status, chkLstBxClientsForCurrentUser, ref DsClientsForCurrentUser);
            FillAllUsers(CustomerId, UserId, Status, chkLstBxClientsForCurrentUser );
        }

         private void CboAllCurrentUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmboUserId=string.Empty ;
            foreach (DataRow Dr in DsClientsALLUsers.Tables[0].Rows)
            {
                if (Dr["UserName"].ToString() == CboAllCurrentUsers.Text)
                {
                    cmboUserId= Dr["UserId"].ToString();
                    
                    break;
                }
            }
            txtUserId_ToBeTransferTo.Text = cmboUserId;
              
            string chatting = ((int)StatusClient.Client_Chatting).ToString();
            FillCurrentClientsForCurrentUser(CustomerId, cmboUserId, chatting, chkLstBxClientsForUsers, ref DsClientsForSpecifiedUser);

            if (txtUserId_ToBeTransferTo.Text!=string.Empty)
            {
                btnSingleTransfer.Enabled = true;
            }

        }


        private void UpdateSession(string ClientsIdstr, string SessionIdStr)
        {

          

            string parm, paramType, paramValues;

             //parm = "@CustomerId,@ClientId,@UserId,@SessionId,@TransferDateEntry";
             //paramType = "int,int,int,int,string";

            parm = "@CustomerId,@ClientId,@UserId,@SessionId,@ToTransfer,@UserId_ToBeTransferTo";
             paramType = "int,int,int,int,string,int,int";

             string TransferStatus, UserId_ToBeTransferTo;
             
            TransferStatus = ((int)ToTransfer.Waiting).ToString();
            UserId_ToBeTransferTo = txtUserId_ToBeTransferTo.Text;

            string[] ClientId = ClientsIdstr.Split(new Char []{','});
            string[] SessionId = SessionIdStr.Split(new Char[] { ',' });


            DataSet nds = new DataSet();
            for (int idx=0; idx<ClientId.Length;idx++)
            {
                if (ClientId[idx].Length > 0 && txtUserId_ToBeTransferTo.Text!=string.Empty )
                {
       //           paramValues = CustomerId + "," + ClientId[idx] + "," + UserId + "," + SessionId[idx] + "," + DateTime.Now.ToString() + "";

                    paramValues = CustomerId + "," + ClientId[idx] + "," + UserId + "," + SessionId[idx] + ","  + TransferStatus + "," + UserId_ToBeTransferTo;

                     //the following is Transfering Queue--But it is suspended
                    // nds = Tawsol.RetreiveData_FromProcedure("SP_InsertClientTransferBetweenUsers", parm, paramType, paramValues, string.Empty);
                     
                    
                    nds = Tawsol.RetreiveData_FromProcedure("UpdateSession_TOTransferClient", parm, paramType, paramValues, string.Empty);
                 }
             }
        }


        private void btnSingleTransfer_Click(object sender, EventArgs e)
        {
            string ClientsIdStr = string.Empty;
            string SessionIdStr = string.Empty;

            foreach (object itemChecked in chkLstBxClientsForCurrentUser.CheckedItems) 
            {
                foreach (DataRow Dr in DsClientsForCurrentUser.Tables[0].Rows)
                { 
                    if  (itemChecked.ToString() == Dr["Clientname"].ToString())
                    {
                         ClientsIdStr += Dr["ClientId"].ToString() + ",";
                         SessionIdStr += Dr["SessionId"].ToString() + ",";
                         break;
                    }
                }
             
            }

            if (ClientsIdStr.Length > 0)
            {
                ClientsIdStr = ClientsIdStr.Substring(0, ClientsIdStr.Length - 1);
                SessionIdStr = SessionIdStr.Substring(0, SessionIdStr.Length - 1);


                UpdateSession(ClientsIdStr, SessionIdStr);
            }
            else
            {
                btnSingleTransfer.Enabled = false;
            }
        }

    }
}