using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient ;
using TawasolWeb.App_WebReferences.Mobily_Tawasol;

using System.Net;

  
namespace TawasolWeb
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public partial class WebForm1 : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!Page.IsPostBack)
			{
				btnConnect.Attributes.Add("onclick","javascript:return TimeOut()");
			}
		
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e)
		{
			Tawasol_Service  Tawasol =new Tawasol_Service();

			string  QuestionText,
				QuestionDate,
				SessionId,
				MessageId,
				QuestionTime,
				ClientId,
				UserId,
				CustomerId;
			//============================================================================
		
			QuestionText="";
			QuestionDate="";
			SessionId="";
			MessageId="";
			QuestionTime="";
			ClientId="";
			UserId="";
			CustomerId="";

			DataSet ds =new DataSet();

			ds= Tawasol.RetrieveData("TblClientele","Ipaddress,ClientId,CustomerId","Status=1 and Ipaddress='" + txtIPAddress.Text + "'",null);

			if (ds.Tables.Count>0 )  
			{
				if (ds.Tables[0].Rows.Count>0)
				{
					if (ds.Tables[0].Rows[0][0].ToString()!="" )
					{
						CustomerId=ds.Tables[0].Rows[0]["CustomerId"].ToString() ;
						ClientId=ds.Tables[0].Rows[0]["ClientId"].ToString() ;
					}
					else
					{
						ClientId="0";
						CustomerId="0";

					}
				}
			}
				
			//---------------------------------------------------------------------------


			//Message to Client To start chating , Always it's Id is (1) .

			QuestionText=" '" + txtSendMessage.Text + "' "; 
			QuestionDate=" '" + System.DateTime.Now.ToString() + "' ";
			QuestionTime=" '" + System.DateTime.Now.ToString() + "' ";
			
			string WhrCondition;

			
			//if SessionState is (0) That's Main that Session is OPEN
			//if SessionState is (1) That's Main that Session is CLOSE
			ds=new DataSet();
			//INSERT TO SESSION
			ds=Tawasol.RetrieveData("tblSession", "ClientId,UserId,CustomerId,SessionId" ,"SessionState=0 and ClientId="+ClientId,null);

			
			UserId="";

			if (ds.Tables.Count>0 )  
			{
				if (ds.Tables[0].Rows.Count>0)
				{
					if (ds.Tables[0].Rows[0][0].ToString()!="" )
					{
						UserId=ds.Tables[0].Rows[0]["UserId"].ToString() ;
						SessionId=ds.Tables[0].Rows[0]["SessionId"].ToString() ;
					}
					else
					{
						UserId="0";
						SessionId="0";
					}
				}  
			}

			//GET LAST NUMBER OF SEESION
			ds.Dispose();

			WhrCondition =  " ClientId=" + ClientId + " and " + 
				" CustomerId=" + CustomerId + " and " +
				" UserId =" + UserId + " and " +
				" SessionId=" + SessionId ;

			ds=new DataSet();

			ds= Tawasol.GetAggregate("TblClientMessage","MessageId",WhrCondition,1);

			int msgid=0;

			if (ds.Tables.Count>0 )
			{
				if (ds.Tables[0].Rows.Count>0 && ds.Tables[0].Columns.Count>0)
				{
					if (ds.Tables[0].Rows[0][0].ToString()!="")
					{
						msgid= Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
					}
				}
			}
			
			msgid++;
			MessageId= msgid.ToString();

			ds.Dispose();
			

///-----------------
///
			string AnswerId="";

			ds=new DataSet();

			ds= Tawasol.GetAggregate("TblSupportAnswers","AnswerId",WhrCondition,1);

			 

			if (ds.Tables.Count>0 )
			{
				if (ds.Tables[0].Rows.Count>0 && ds.Tables[0].Columns.Count>0)
				{
					if (ds.Tables[0].Rows[0][0].ToString()!="")
					{
						AnswerId= ds.Tables[0].Rows[0][0].ToString();
					}
				}
			}
			

			ds.Dispose();
			
//----------------------

			string StrColumnsName="MessageId,ClientId,CustomerId,Userid,Sessionid,MessageQuestion,DateMessage,AnswerId";
			string StrColumnsValues="";
				
			if (msgid!=0 && ClientId!="0" &&  CustomerId!="0" && UserId!= "0")
			{
				StrColumnsValues= msgid +"," + ClientId + "," + CustomerId + "," + UserId + "," + SessionId + "," + QuestionText +"," + QuestionDate + "," +AnswerId  ;

				//INSERT TO SupportAnswers
				Tawasol.InsertData("TblClientMessage" , StrColumnsName  , StrColumnsValues);
			}
		}

		protected void lnkBtnRefresh_Click(object sender, System.EventArgs e)
		{
			Tawasol_Service  Tawasol=new Tawasol_Service();

			DataSet Ds=new DataSet();

//			string CustomerId, ClientId, SessionId , UserId;
//
//			CustomerId="";
//            ClientId="";
//			SessionId ="";
//			UserId="";


			
			Ds=Tawasol.RetrieveData("VwQuestionAnswer",null," ClientId="+txtIPAddress.Text ,null);


			string strmsgs;
			strmsgs="";

			if (Ds.Tables.Count>0)
			{
				for (int i=0; i<Ds.Tables[0].Rows.Count; i++)
				{
					strmsgs += Ds.Tables[0].Rows[i]["clientName"].ToString()  + ":";
					strmsgs += Ds.Tables[0].Rows[i]["MessageQuestion"].ToString()  + "\n";
					strmsgs += Ds.Tables[0].Rows[i]["UserName"].ToString()  + ":";
					strmsgs += Ds.Tables[0].Rows[i]["AnswerText"].ToString()  + "\n";
				}	

				txtRecievedMessages.Text=strmsgs;
			}
			
			Ds.Dispose();
		}

		protected void btnConnect_Click(object sender, System.EventArgs e)
		{
			Tawasol_Service  Tawasol=new Tawasol_Service();

			DataSet ds=new DataSet();

			
// if Aggregate 1 it is Mains That MAX

			ds=Tawasol.GetAggregate("tblClientele","ClientId","",1); 
            			
			double Scalar=0;

			if (ds.Tables.Count>0 )
			{
				Scalar=Convert.ToDouble(ds.Tables[0].Rows[0][0].ToString());
				if ( Scalar >0)
				{
					Scalar++;				
				}
				else
				{
					Scalar=1;
				}
			}
						
			ds.Dispose(); 

			if (txtIPAddress.Text.Trim().Length==0)
			{
				//The following Line used to Retrive Ip Address for Client
				// and I put Remark sign becuase Ip address for local not change
				// so I use client id for Test only
				// In Real World test I use Ip address by remove remark sign from the following line
				//txtIPAddress.Text = Request.UserHostAddress ;

				txtClientId.Text=Scalar.ToString();
				txtIPAddress.Text = txtClientId.Text; //Request.UserHostAddress ;
			}

			string ColumnsName,ColumnsValues,DateEnter,TimeEnter,Handlestatus,Customerid;

			DateEnter=System.DateTime.Now.ToShortDateString(); 
			
			TimeEnter=System.DateTime.Now.ToShortTimeString();

			Handlestatus="0";
			
			Customerid="1";

			ColumnsName   ="ClientId,ClientName,status,DateEnter,TimeEnter,Handlestatus,Customerid,IpAddress";
			
			ColumnsValues = Scalar.ToString() + ",'" +  
				txtClientName.Text + "',0,'" + 
				DateEnter+ "','" +
				TimeEnter +"',"+ Handlestatus + ","+
				Customerid + "," + 
				"'" + txtIPAddress.Text + "'" ; 

			 ds=new DataSet();

			ds=Tawasol.RetrieveData("VwClientSessionState","IPAddress"," SessionState=0 and IPAddress =" + "'" + txtIPAddress.Text + "'",null);

			
			if (ds.Tables.Count>0)
			{
				if (ds.Tables[0].Rows.Count ==0 )
				{
					Tawasol.InsertData("tblClientele",ColumnsName,ColumnsValues);
				}
				else
				{
					if (ds.Tables[0].Rows.Count >0  && ds.Tables[0].Rows[0][0].ToString()=="" )
					{
						Tawasol.InsertData("tblClientele",ColumnsName,ColumnsValues);
					}
				}
			}
			

		}

		protected void btnGetHandleStatus_Click(object sender, System.EventArgs e)
		{
			DataSet ds=new DataSet();
			Tawasol_Service  Tawasol=new Tawasol_Service();

			ds=Tawasol.RetrieveData("tblClientele","ClientId,IPAddress,status"," ClientId="+  txtClientId.Text +" and IPAddress =" + "'" + txtIPAddress.Text + "'",null);

			if (ds.Tables.Count>0)
			{
				if(ds.Tables[0].Rows.Count>0)
				{
					if(ds.Tables[0].Rows[0][0].ToString()!="")
					{
						txtHandleStatus.Text =ds.Tables[0].Rows[0][2].ToString();
					}
					else
					{
						txtHandleStatus.Text="0";
					}
				}
				else
				{
					txtHandleStatus.Text="0";
				}
			}

			else
			{
				txtHandleStatus.Text="0";
			}
		}
	}
}
