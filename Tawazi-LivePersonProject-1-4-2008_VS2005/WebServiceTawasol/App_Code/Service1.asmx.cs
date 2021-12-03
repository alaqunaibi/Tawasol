using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;




namespace WebServiceTawasol
{
	/// <summary>
	/// Summary description for Service1.
	/// </summary>
	
	[WebService (Namespace="http://www.Mobily.ws/TawasolServices/call")]

	public class Tawasol_Service : System.Web.Services.WebService
	{
		

		public SqlConnection  Sqlconn;
		enum  StatusClient 
		{
			Client_Pending=0,
			Client_Handle=1,
			Client_Close=2

		};

			
		public Tawasol_Service()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
			
		}

		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		// WEB SERVICE EXAMPLE
		// The HelloWorld() example service returns the string Hello World
		// To build, uncomment the following lines then save and build the project
		// To test this web service, press F5

		[WebMethod]	
		public void ConnectToDB()
		{

			string ServerName= "Qunaibi";
			string DBname    = "Tawasol";
			string usr="ala";
			string password = "ala";

			  Sqlconn= new SqlConnection();


            ////Sqlconn.ConnectionString=" Server="+ ServerName + ";" + 
            //                         " DataBase="+ DBname + ";" + 
            //                         " uid="+ usr + ";" + 
            //                         " pwd=" + password + ";";
            Sqlconn.ConnectionString = @"Data Source=ALAQUNAIBI-PC\SQLEXPRESS;Initial Catalog=tawasol;Integrated Security=True";

			Sqlconn.Open();
 		}

		[WebMethod]	
		public void InsertData(string Table, string Columns, string Values )
		{
		
			char[] Delemiter={','};

				string[] FieldName= Columns.Split(Delemiter);
			string[] FieldValues= Values.Split(Delemiter);

			ConnectToDB();

			if (FieldName.Length != FieldValues.Length )
			{
				Sqlconn.Close();
				throw (new  Exception("Error .Occurs when  Field Names and Values Item not as same count"));
     		}
	

			SqlCommand comm = new SqlCommand();
			comm.Connection = Sqlconn;
			comm.CommandType= CommandType.StoredProcedure;
			comm.CommandText= "InsertIntoTables"; 

			SqlParameter prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Table";
			prmtr_Table.Value= Table;
			comm.Parameters.Add(prmtr_Table);

			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Columns";
			prmtr_Table.Value= Columns;
			comm.Parameters.Add(prmtr_Table);

			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Values";
			prmtr_Table.Value= Values;
			comm.Parameters.Add(prmtr_Table);

			comm.ExecuteNonQuery(); 
		}
		
		[WebMethod]	
		public void DeleteData(string Table, string whr)
		{
			ConnectToDB();

			SqlCommand comm = new SqlCommand();
			comm.Connection = Sqlconn;
			comm.CommandType= CommandType.StoredProcedure;
			comm.CommandText= "DeleteData"; 

			SqlParameter prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Table";
			prmtr_Table.Value= Table;
			comm.Parameters.Add(prmtr_Table);

			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@whr";
			prmtr_Table.Value= whr;
			comm.Parameters.Add(prmtr_Table);

			comm.ExecuteNonQuery();

		}
		
		[WebMethod]	
		public void UpdateData(string Table, string Columns, string Values ,string whr)
		{
			ConnectToDB();

			string ColumnsValues="";
			char[] Delemiter={','};

			string[] FieldName= Columns.Split(Delemiter);
			string[] FieldValues= Values.Split(Delemiter);

			

			if (FieldName.Length != FieldValues.Length )
			{
				Sqlconn.Close();
				throw (new  Exception("Error .Occurs when  Field Names and Values Item not as same count"));
			}

			for (int i=0; i<FieldName.Length;i++)
			{
				ColumnsValues+= FieldName[i].ToString()  + "=" +FieldValues[i].ToString() + ",";
			}

			if (ColumnsValues.Length >0 && ColumnsValues.IndexOf(",") >0)
			{
				ColumnsValues=ColumnsValues.Substring(0,ColumnsValues.Length -1);
			}
			else
			{
				Sqlconn.Close();
				throw (new Exception("Error .Occurs when  Field Names and Values Item not as same count"));
				
			}

		SqlCommand comm = new SqlCommand();
				   comm.Connection = Sqlconn;
				   comm.CommandType= CommandType.StoredProcedure;
				   comm.CommandText= "UpdateTables"; 

			SqlParameter prmtr_Table=new SqlParameter();
						prmtr_Table.ParameterName= "@Table";
						prmtr_Table.Value= Table;
						comm.Parameters.Add(prmtr_Table);

						prmtr_Table=new SqlParameter();
						prmtr_Table.ParameterName= "@ColumnsValues";
						prmtr_Table.Value= ColumnsValues;
						comm.Parameters.Add(prmtr_Table);

						prmtr_Table=new SqlParameter();
						prmtr_Table.ParameterName= "@whr";
						prmtr_Table.Value= whr;
						comm.Parameters.Add(prmtr_Table);

			comm.ExecuteNonQuery();

		}
		
		[WebMethod]	
		public DataSet RetrieveData(string Table, string Columns, string whr, string Orderby)
		{
			ConnectToDB();
			SqlCommand comm = new SqlCommand();
			comm.Connection = Sqlconn;
			comm.CommandType= CommandType.StoredProcedure;
			comm.CommandText= "RetrieveData"; 

			

			SqlParameter prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Table";
			prmtr_Table.Value= Table;
			comm.Parameters.Add(prmtr_Table);

			  prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Columns";
			prmtr_Table.Value= Columns;
			comm.Parameters.Add(prmtr_Table);

			  prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@whr";
			prmtr_Table.Value= whr;
			comm.Parameters.Add(prmtr_Table);
			  
			
			
			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Orderby";
			prmtr_Table.Value= Orderby;
			comm.Parameters.Add(prmtr_Table);
			 
			 
			SqlDataAdapter  adptr=new SqlDataAdapter(comm);

			DataSet ds = new DataSet();
			adptr.Fill(ds);
			Sqlconn.Close();
 
			return ds;

		}

		[WebMethod]
		public DataSet CheckLogin(string UserID, string PasswordID, string CustomerLogin, string CustomerPassword )
		{
			ConnectToDB();
			
			SqlCommand salesCMD = new SqlCommand("CheckUserName", Sqlconn);
			salesCMD.CommandType = CommandType.StoredProcedure;
			
			SqlParameter myParm=new SqlParameter();
			myParm.ParameterName= "@UserID";
			myParm.SqlDbType = SqlDbType.NVarChar;
			myParm.Size = 50;
			myParm.Value= UserID;
			salesCMD.Parameters.Add(myParm);

		    myParm=new SqlParameter();
			myParm.ParameterName= "@PasswordID";
			myParm.SqlDbType = SqlDbType.NVarChar;
			myParm.Size = 50;
			myParm.Value= PasswordID;
			salesCMD.Parameters.Add(myParm);

			
			myParm=new SqlParameter();
			myParm.ParameterName= "@CustomerLogin";
			myParm.SqlDbType = SqlDbType.NVarChar;
			myParm.Size = 50;
			myParm.Value= CustomerLogin;
			salesCMD.Parameters.Add(myParm);


			myParm=new SqlParameter();
			myParm.ParameterName= "@CustomerPassword";
			myParm.SqlDbType = SqlDbType.NVarChar;
			myParm.Size = 50;
			myParm.Value= CustomerPassword;
			salesCMD.Parameters.Add(myParm);

			
//			myParm=new SqlParameter();
//			myParm.Value = CustomerPassword;
//			myParm.Direction =ParameterDirection.Output  ;
//			myParm = salesCMD.Parameters.Add("@ReturnValue", SqlDbType.Int);


			SqlDataAdapter da = new SqlDataAdapter(salesCMD);

			DataSet ds=new DataSet();
			da.Fill(ds,"abc");
	
			Sqlconn.Close();

			return ds;
		}

		[WebMethod]
		public double RetreiveScalarData_FromProcedure(string ProcedureName, string ParameterNames, string ParameterTypes, string ParameterValues )
		{
			ConnectToDB();
			SqlCommand comm = new SqlCommand();
			comm.Connection = Sqlconn;
			comm.CommandType= CommandType.StoredProcedure;
			comm.CommandText= ProcedureName;
			SqlParameter prmtr_Table;

			if  (ParameterNames.IndexOf(",")<0 )
			{
				prmtr_Table=new SqlParameter();
				prmtr_Table.Value=  ParameterValues ;
				prmtr_Table.ParameterName= ParameterNames;
				comm.Parameters.Add(prmtr_Table);
			}
			else
			{
				char[] Delim={','};
				string[] ParmNames = ParameterNames.Split(Delim);
				string[] ParmTypes = ParameterTypes.Split(Delim);
				string[] ParmValues= ParameterValues.Split(Delim);
				string Nam,Val,Typ;

				for (int j=0;j<=ParmNames.Length-1;j++ )
				{
					Nam=ParmNames[j].ToString();
					Typ=ParmTypes[j].ToString();
					Val= ParmValues[j].ToString() ;
					prmtr_Table=new SqlParameter();
					prmtr_Table.ParameterName= Nam;
					prmtr_Table.Value= Val;
					comm.Parameters.Add(prmtr_Table);
				}
			}	
			
					   SqlDataAdapter  adptr=new SqlDataAdapter(comm);

					   DataSet ds = new DataSet();
					   adptr.Fill(ds);
			
			double 	res =0 ;

			res= Convert.ToDouble( ds.Tables[0].Rows[0][0].ToString() );
			Sqlconn.Close();
 
			return res;

		}

		[WebMethod]	
		public DataSet RetreiveData_FromProcedure(string ProcedureName, string ParameterNames, string ParameterTypes, string ParameterValues ,string Whr)
		{
				ConnectToDB();
				SqlCommand comm = new SqlCommand();
				comm.Connection = Sqlconn;
				comm.CommandType= CommandType.StoredProcedure;
				comm.CommandText= ProcedureName;
				SqlParameter prmtr_Table;

                if (ParameterTypes != "" && ParameterNames != "" && ParameterValues!="") 
                {
                    if (ParameterNames.IndexOf(",") < 0)
                    {
                        prmtr_Table = new SqlParameter();
                        if (/*ParameterTypes.ToLower() == "string" ||*/ ParameterTypes.ToLower() == "DateTime".ToLower())
                        {
                            prmtr_Table.Value = "'" + ParameterValues + "'";
                        }
                        else
                        {
                            prmtr_Table.Value = ParameterValues;
                        }

                        prmtr_Table.ParameterName = ParameterNames;
                        comm.Parameters.Add(prmtr_Table);
                    }
                    else
                    {
                        char[] Delim ={ ',' };
                        string[] ParmNames = ParameterNames.Split(Delim);
                        string[] ParmTypes = ParameterTypes.Split(Delim);
                        string[] ParmValues = ParameterValues.Split(Delim);

                        string Nam, Val, Typ;

                        for (int j = 0; j <= ParmNames.Length - 1; j++)
                        {
                            Nam = ParmNames[j].ToString();
                            Typ = ParmTypes[j].ToString();

                            if (/*Typ.ToLower() == "string" || */ Typ.ToLower() == "DateTime".ToLower())
                            {
                                Val = "'" + ParmValues[j].ToString() + "'";
                            }
                            else
                            {
                                Val = ParmValues[j].ToString();
                            }

                            prmtr_Table = new SqlParameter();

                            prmtr_Table.ParameterName = Nam;
                            prmtr_Table.Value = Val;
                            comm.Parameters.Add(prmtr_Table);
                        }
                    }
                }
		

		if (!(  Whr==null || Whr==""))
		{
			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@whr";
			prmtr_Table.Value= Whr;
			comm.Parameters.Add(prmtr_Table);
		} 	 
			 
			SqlDataAdapter  adptr=new SqlDataAdapter(comm);
			
			DataSet ds = new DataSet();
			adptr.Fill(ds);
			Sqlconn.Close();
 
			return ds;

		}

		[WebMethod]
		public DataSet GetAggregate(string TableName, string ColumnName, string Whr, int agregateType)
		{
			ConnectToDB();
			SqlCommand comm = new SqlCommand();
			comm.Connection = Sqlconn;
			comm.CommandType= CommandType.StoredProcedure;
			comm.CommandText= "GetAggregate"; 
 
			SqlParameter prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@TableName";
			prmtr_Table.Value= TableName;
			comm.Parameters.Add(prmtr_Table);

			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@ColumnName";
			prmtr_Table.Value= ColumnName;
			comm.Parameters.Add(prmtr_Table);

			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@Whr";
			prmtr_Table.Value= Whr;
			comm.Parameters.Add(prmtr_Table);
			  
			prmtr_Table=new SqlParameter();
			prmtr_Table.ParameterName= "@agregateType";
			prmtr_Table.Value= agregateType;
			comm.Parameters.Add(prmtr_Table);
			 
			SqlDataAdapter  adptr=new SqlDataAdapter(comm);

			DataSet ds = new DataSet();
			adptr.Fill(ds);
			Sqlconn.Close();
			return ds;
		}
		

	}
}
