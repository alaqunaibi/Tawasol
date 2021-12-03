using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Mobily_Tawasol;
using Ajax;

 
    public partial class WebIntro : System.Web.UI.Page
    {


        public static string CustomerId ;
        public static int i = 0;
        public static string VarClientId;
        public string languageId  ;

        enum StatusClient
        {
            Client_Pending = 0,
            Client_Handle = 1,
            Client_Block = 2,
            Client_Close = 3
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.Utility.RegisterTypeForAjax(typeof(WebIntro));

            // Put user code to initialize the page here
           
                 CustomerId =   Request.QueryString["CustomerId"];
                languageId =   Request.QueryString["languageId"];
 
            if (!Page.IsPostBack)
            {
                VarClientId = "";
               
                

            }
        }
        protected void btnConnect_Click(object sender, EventArgs e)
        {
            Label1.Text = "0";

            Tawasol_Service Tawasol = new  Tawasol_Service();

            DataSet ds = new DataSet();


            // if Aggregate 1 it is Mains That MAX

            ds = Tawasol.GetAggregate("tblClientele", "ClientId", "", 1);

            double Scalar = 0;

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString().Trim() != "")
                    {
                        Scalar = Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
                    }
                }
                if (Scalar > 0)
                {
                    Scalar++;
                }
                else
                {
                    Scalar = 1;
                }
            }

            ds.Dispose();

            if (txtIPAddress.Text.Trim().Length == 0)
            {
                //The following Line used to Retrive Ip Address for Client
                // and I put Remark sign becuase Ip address for local not change
                // so I use client id for Test only
                // In Real World test I use Ip address by remove remark sign from the following line
                //txtIPAddress.Text = Request.UserHostAddress ;

                txtClientId.Text = Scalar.ToString();
                txtIPAddress.Text = txtClientId.Text; //Request.UserHostAddress ;
                VarClientId = txtClientId.Text;
            }

            string ColumnsName, ColumnsValues, DateEnter, TimeEnter, Handlestatus;

            DateEnter = System.DateTime.Now.ToShortDateString();

            TimeEnter = System.DateTime.Now.ToShortTimeString();

            Handlestatus = "0";

            //Customerid="1";

            ColumnsName = "ClientId,ClientName,status,DateEnter,TimeEnter,Handlestatus,Customerid,IpAddress,Mobile,Email";

            ColumnsValues = Scalar.ToString() + ",'" +
                txtClientName.Text + "',0,'" +
                DateEnter + "','" +
                TimeEnter + "'," + Handlestatus + "," +
                CustomerId + "," +
                "'" + txtIPAddress.Text + "',"  +
                "'" + txtMobile.Text + "'," +
                "'" + txtEmail.Text + "'" ;

            ds = new DataSet();

            ds = Tawasol.RetrieveData("VwClientSessionState", "IPAddress", " SessionState=0 and IPAddress =" + "'" + txtIPAddress.Text + "'", null);


            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Tawasol.InsertData("tblClientele", ColumnsName, ColumnsValues);
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() == "")
                    {
                        Tawasol.InsertData("tblClientele", ColumnsName, ColumnsValues);
                    }
                }
            }
            btnConnect.Style["display"] = "none";
            Timer1.Enabled = true;

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

     

        protected void CheckStartChatting()
        {
            Label1.Text = (++i).ToString();
            Tawasol_Service Tawasol = new Tawasol_Service();
            if (VarClientId != string.Empty)
            {
                DataSet Ds = new DataSet();
                DataSet DsMsg = new DataSet();

              
                Ds = Tawasol.RetrieveData("VwQuestionAnswer", "AnswerText", "CustomerId=" + CustomerId + " and status=1 and ClientId=" + VarClientId, string.Empty );

                 if (CheckDataSet(Ds))
                            {

                                string paramValues = CustomerId + "," + languageId + ",1,NewClient";

                                DsMsg = Tawasol.RetreiveData_FromProcedure("Sp_RetrieveSystemMessages", "@customerId ,@languageId,@MessageTypeId,@MessageName", "int,int,int,string", paramValues, string.Empty);
                     
                                

                                 if (CheckDataSet(DsMsg))
                                {
                                    lblWelComeLetter.Text = DsMsg.Tables[0].Rows[0][0].ToString();
                                    
                                    TableMessage.Style["display"] = "block";
                                    SendMsgTxt.Style["display"] = "block";

                                    UpdatePanel_msg.Update();
                                    UpdatePanel_SendTools.Update();

                                    Timer2.Enabled = true;
                                    Timer1.Enabled = false;
                            }
                      }
            }
        }

        protected void Refresh()
        {

            Tawasol_Service Tawasol = new Tawasol_Service();

            DataSet Ds = new DataSet();


            Ds = Tawasol.RetreiveData_FromProcedure("ShowChatMessages", "", "", "", "clientId=" + VarClientId);


            string strmsgs;
            strmsgs = "";

            if (Ds.Tables.Count > 0)
            {
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    strmsgs += Ds.Tables[0].Rows[i]["AnswrQuest"].ToString() + "\n";
                }

                txtRecieveMessages.Text = strmsgs;
            }

            Ds.Dispose();
        }

        protected void btnGetHandleStatus_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Tawasol_Service Tawasol = new Tawasol_Service();

            ds = Tawasol.RetrieveData("tblClientele", "ClientId,IPAddress,status", " ClientId=" + txtClientId.Text + " and IPAddress =" + "'" + txtIPAddress.Text + "'", null);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() != "")
                    {
                        txtHandleStatus.Text = ds.Tables[0].Rows[0][2].ToString();
                    }
                    else
                    {
                        txtHandleStatus.Text = "0";
                    }
                }
                else
                {
                    txtHandleStatus.Text = "0";
                }
            }

            else
            {
                txtHandleStatus.Text = "0";
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            txtSendMessage.Text = txtSendMessage.Text.Replace(",", "،");
            txtSendMessage.Text = txtSendMessage.Text.Replace("'", "‘");




            Tawasol_Service Tawasol = new Tawasol_Service();

            string QuestionText,
                QuestionDate,
                SessionId,
                MessageId,
                QuestionTime,
                ClientId,
                UserId;
            //============================================================================

            QuestionText = "";
            QuestionDate = "";
            SessionId = "";
            MessageId = "";
            QuestionTime = "";
            ClientId = "";
            UserId = "";


            DataSet ds = new DataSet();

            ds = Tawasol.RetrieveData("TblClientele", "Ipaddress,ClientId,CustomerId", "Status=1 and Ipaddress='" + txtIPAddress.Text + "'", null);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() != "")
                    {
                         ClientId = ds.Tables[0].Rows[0]["ClientId"].ToString();
                    }
                    else
                    {
                        ClientId = "0";
 
                    }
                }
            }

            //---------------------------------------------------------------------------


            //Message to Client To start chating , Always it's Id is (1) .

            QuestionText = " '" + txtSendMessage.Text + "' ";
            QuestionDate = " '" + System.DateTime.Now.ToString() + "' ";
            QuestionTime = " '" + System.DateTime.Now.ToString() + "' ";

            string WhrCondition;


            //if SessionState is (0) That's Main that Session is OPEN
            //if SessionState is (1) That's Main that Session is CLOSE
            ds = new DataSet();
            //INSERT TO SESSION
            ds = Tawasol.RetrieveData("tblSession", "ClientId,UserId,CustomerId,SessionId", "SessionState=0 and ClientId=" + ClientId, null);


            UserId = "";

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() != "")
                    {
                        UserId = ds.Tables[0].Rows[0]["UserId"].ToString();
                        SessionId = ds.Tables[0].Rows[0]["SessionId"].ToString();
                    }
                    else
                    {
                        UserId = "0";
                        SessionId = "0";
                    }
                }
            }

            //GET LAST NUMBER OF SEESION
            ds.Dispose();

            WhrCondition = " ClientId=" + ClientId + " and " +
                " CustomerId=" + CustomerId + " and " +
                " UserId =" + UserId + " and " +
                " SessionId=" + SessionId;

            ds = new DataSet();

            ds = Tawasol.GetAggregate("TblClientMessage", "MessageId", WhrCondition, 1);

            int msgid = 0;

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Columns.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() != "")
                    {
                        msgid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                    }
                }
            }

            msgid++;
            MessageId = msgid.ToString();

            ds.Dispose();


            ///-----------------
            ///
            string AnswerId = "0";

            ds = new DataSet();

            ds = Tawasol.GetAggregate("TblSupportAnswers", "AnswerId", WhrCondition, 1);



            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Columns.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() != "")
                    {
                        AnswerId = ds.Tables[0].Rows[0][0].ToString();
                    }
                }
            }


            ds.Dispose();

            //----------------------

            string StrColumnsName = "MessageId,ClientId,CustomerId,Userid,Sessionid,MessageQuestion,DateMessage,AnswerId";
            string StrColumnsValues = "";

            if (msgid != 0 && ClientId != "0" && CustomerId != "0" && UserId != "0")
            {
                StrColumnsValues = msgid + "," + ClientId + "," + CustomerId + "," + UserId + "," + SessionId + "," + QuestionText + "," + QuestionDate + "," + AnswerId;

                //INSERT TO SupportAnswers
                Tawasol.InsertData("TblClientMessage", StrColumnsName, StrColumnsValues);
            }
        }

        protected void Refresh(object sender, EventArgs e)
        {

            if (txtIPAddress.Text.Length > 0)
            {
                Refresh();
                UpdatePanel_msg.Update();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            CheckStartChatting();
        }

        protected void ChattingOut()
        {

            string ClientId = txtClientId.Text;

            string WhrCondition;
            Tawasol_Service Tawasol = new Tawasol_Service();



            WhrCondition = " ClientId=" + ClientId + " and " +
                           " CustomerId=" + CustomerId;


            //==================================

            int y = (int)StatusClient.Client_Close;

            //UPDATE TO CLIENT TABLE
            Tawasol.UpdateData("TblClientele", "Status,DateExit", y.ToString() + ",'"+DateTime.Now+"'" , WhrCondition);

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (txtClientId.Text.Length>0)
            {
                ChattingOut();
            }
          
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "closewindow", "self.close()", true);
        }
}
 