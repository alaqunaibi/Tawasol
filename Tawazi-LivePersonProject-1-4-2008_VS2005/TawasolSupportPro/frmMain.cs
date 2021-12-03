using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient ;
using System.Threading; 
using System.Web.Services.Protocols ;  
using System.Web.Services;
using TawasolSupportPro.ConnectionService;
using System.Xml;
using System.Xml.Serialization; 
using System.IO;
using System.Media;
using System.Text;


namespace TawasolSupportPro
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {

        #region Declarations



        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuControl;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.MenuItem mnuTools;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuCanned;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuLogin;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ToolBar ToolbarChat;
        private System.Windows.Forms.ImageList imgToolbarChat;
        private System.Windows.Forms.ToolBarButton toolBarButton_TakeChat;
        private System.Windows.Forms.ToolBarButton toolBarButton_NextResponse;
        private System.Windows.Forms.ToolBarButton toolBarButton_Invite;
        private System.Windows.Forms.ToolBarButton toolBarButton_Engage;
        private System.Windows.Forms.ToolBarButton toolBarButton_UP;
        private System.Windows.Forms.ToolBarButton toolBarButton_Down;
        private System.Windows.Forms.ImageList imgLvw_lstMessage;
        private System.ComponentModel.IContainer components;
        private Utilities util;

        //----------------------------------------------------------------------
        //Threading Management   

        private BackgroundWorker backgroundWorker1;



        //----------------------------------------------------------------------
        private TextBox textBox1;
        private BackgroundWorker backgroundWorker2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView DGVClientInfo;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblInfo;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private RichTextBox lstMessages;
        private TextBox txtMessage;
        private Button btnSendMsg;
        private MenuItem mnuLogout;
        private MenuItem mnuFileSeparator1;
        private MenuItem mnuSettings;
        private MenuItem mnuProfile;
        private MenuItem mnuFileSeparator2;
        private MenuItem mnuExit;
        private MenuItem mnuAcceptNextChat;
        private MenuItem mnuNextResponse;
        private MenuItem mnuAcceptChat;
        private MenuItem mnuRefuseChat;
        private MenuItem mnuControlSeparator1;
        private MenuItem mnuInvite;
        private MenuItem mnuEngage;
        private MenuItem mnuBlockForChat;
        private MenuItem mnuSendPrivateMessage;
        private MenuItem mnuChatActions;
        private MenuItem mnuControlSeparator2;
        private MenuItem mnuChatHistory;
        private MenuItem mnuAllSessionhistory;
        private MenuItem mnuControlSeparator3;
        private MenuItem mnuCobrowse;
        private MenuItem mnuSubChatActionTransferChat;
        private MenuItem mnuSubChatActionStopChat;
        private MenuItem mnuSubChatActionPushPage;
        private MenuItem mnuSubChatActionSendHTML;
        private MenuItem mnuToolbars;
        private MenuItem mnuStatusBar;
        private MenuItem mnuAlwaysOnTop;
        private MenuItem mnuSort;
        private MenuItem mnuCustomize;
        private MenuItem mnuViewSeparator1;
        private MenuItem mnuSelectNextItem;
        private MenuItem mnuSelectPreviousItem;
        private MenuItem mnuShowList;
        private MenuItem mnuViewSeparator2;
        private MenuItem mnuFilter;
        private MenuItem mnuMainToolbars;
        private MenuItem mnuFormatChatToolbars;
        private MenuItem mnuGenerateTags;
        private MenuItem mnuAddEmailSignature;
        private MenuItem mnuToolsSeparator1;
        private MenuItem mnuInformation;
        private MenuItem mnuModify;
        private MenuItem mnuPopUp;
        private MenuItem mnuCannedSeparator1;
        private MenuItem mnuMemorize;
        private MenuItem mnuIntroductions;
        private MenuItem mnuConversational;
        private MenuItem mnuClosing;
        private MenuItem mnuHelpTopics;
        private MenuItem mnuHelpSeparator1;
        private MenuItem mnuGettingStartedandTraining;
        private MenuItem mnuHelpSeparator2;
        private MenuItem mnuFrequentlyAskedQuestions;
        private MenuItem mnuCustomerCenter;
        private MenuItem mnuReportError;
        private MenuItem mnuHelpSeparator3;
        private MenuItem mnuAbout;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton TransferToolStripButton;
        private ToolStripButton StopToolStripButton;
        private ToolStripButton HistoryToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton1;
        private ToolStripContainer toolStripContainer2;
        private MenuItem mnuDashboard;
        private MenuItem mnuOperator;
        private MenuItem menuItem2;
        private MenuItem mnuHomePage;
        private MenuItem menuItem4;
        private MenuItem mnuAdminConsole;
        private MenuItem mnuChatTranscripts;
        private MenuItem mnuKnowledgebase;
        private MenuItem mnuSignUp;
        private MenuItem menuItem3;
        private MenuItem mnuUpdate;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView lstvClients;
        private ToolStrip toolStrip2;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cutToolStripButton1;
        private ToolStripButton copyToolStripButton1;
        private ToolStripButton pasteToolStripButton1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton helpToolStripButton;
        private ToolStripComboBox toolStripComboBoxFONT;
        private ToolStripComboBox toolStripComboBoxFontSize;
        private Panel panel1;
        private Label lblClientName;
        private Label lblConnectedClientName;
        private Panel panel2;
        private TableLayoutPanel tblLytPnlTitlestaticals;
        private Label lblFilter;
        private ComboBox comboBox1;
        private Label lblWaitforChat;
        private Label lblWaitforChatnumber;
        private Label lblVisitors;
        private Label lblVisitorsinSite;
        private Label lblStatus;
        private ComboBox cboState;



        public static DataSet DataSetInfo;





        #endregion


        enum StatusClient
        {
            Client_Pending = 0,
            Client_Handle = 1,
            Client_Block = 2,
            Client_Close = 3,
            ContinueWithAnotherUser = 4

        };

        enum SessionStatus
        {
            Open = 0,
            Close = 1,
            ContinueWithAnotherUser = 2
        };

        enum TransferStatus
        {
            Waiting = 0,
            Accept = 1,
            Reject = 2
        }

        public class Filling
        {
            private ListView vw;
            private Label W;
            private Label V;
            private int VisitorsNumber;
            private int WaitingList;
            private int Chating;


            private DataSet ds;

            public Filling(ListView vw, Label W, Label V)
            {
                this.vw = vw;

                this.W = W;
                this.V = V;


            }

            public bool IsItExistInDataSet(DataSet ds, string LstvClientId)
            {
                bool res = false;

                foreach (DataRow Dr in ds.Tables[0].Rows)
                {
                    if (Dr["Client_Id"].ToString() == LstvClientId &&
                        (Dr["status"].ToString().ToLower() == "block" || Dr["status"].ToString().ToLower() == "out"))
                    {
                        res = true;
                        break;

                    }
                }
                return res;
            }


            public DataRow FindItemIndDataSet(DataSet ds, string itemname, ListViewItem itemvalue)
            {
                DataRow ReturnRow = ds.Tables[0].NewRow();

                foreach (DataRow Dr in ds.Tables[0].Rows)
                {
                    if (Dr["ToTransfer"].ToString() == ((int)TransferStatus.Accept).ToString() && Dr[itemname].ToString() == itemvalue.Text)
                    {
                        vw.Items.Remove(itemvalue);
                        ReturnRow = Dr;
                        break;
                    }
                }

                return ReturnRow;
            }
            public void AddDataRowIntoListView(DataRow ResultDataRow)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = ResultDataRow.ItemArray[0].ToString();
                lvi.BackColor = Color.White;

                for (int dt = 1; dt < ResultDataRow.ItemArray.Length; dt++)
                {
                    ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = ResultDataRow.ItemArray[dt].ToString();
                    lvi.Name = ResultDataRow[dt].ToString();
                    lvi.SubItems.Add(lvsi);
                    lvi.ImageIndex = 1;
                }
                vw.Items.Add(lvi);
            }

            public void CheckClientStatusInListView(DataSet ds)
            {
                //           DataRow ResultDataRow;

                foreach (ListViewItem lvwitem in vw.Items)
                {

                    //                     if (lvwitem.SubItems[11].Text == ((int)TransferStatus.Accept).ToString())
                    //                    {
                    //                         ResultDataRow = FindItemIndDataSet(ds, "Client_Id", lvwitem);
                    //                        AddDataRowIntoListView(ResultDataRow);
                    //                   }
                    if (IsItExistInDataSet(ds, lvwitem.Text))
                    {
                        vw.Items.Remove(lvwitem);
                    }
                }
                vw.Refresh();
            }

            public bool IsItExistinListView(DataRow ClientRow)
            {
                bool itExist = false;
                foreach (ListViewItem lvwitem in vw.Items)
                {
                    if (lvwitem.Text == ClientRow["Client_Id"].ToString())
                    {
                        itExist = true;
                        break;
                    }
                }
                return itExist;
            }


            public void Statistics()
            {
                WaitingList = 0;
                Chating = 0;
                VisitorsNumber = 0;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["Status"].ToString().ToLower() == "in queue")
                    {
                        WaitingList++;
                    }
                    if (dr["Status"].ToString().ToLower() == "chatting")
                    {
                        Chating++;
                    }
                    VisitorsNumber = Chating + WaitingList;
                }


                W.Text = WaitingList.ToString();
                V.Text = VisitorsNumber.ToString();


            }

            public void FillListView()
            {

                Tawasol_Service Tawasol = new Tawasol_Service();

                string whr = "ALL";
                string CustomerId, UserId;


                CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();
                UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();

                try
                {
                    ds = Tawasol.RetreiveData_FromProcedure("sp_ListView", "@customerid", "float", CustomerId, whr);

                    DataTable RecentDt = new DataTable();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        vw.BeginUpdate();
                        ListViewItem lvi;
                        ListViewItem.ListViewSubItem lvsi;

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {

                            if (!IsItExistinListView(dr))
                            {
                                lvi = new ListViewItem();


                                //  lvi.UseItemStyleForSubItems = false;

                                lvi.Text = dr.ItemArray[0].ToString();

                                for (int dt = 1; dt < dr.ItemArray.Length; dt++)
                                {
                                    lvsi = new ListViewItem.ListViewSubItem();
                                    if (dr["ToTransfer"].ToString() == "0" && dr["UserId_ToBeTransferTo"].ToString() == UserId)
                                    {// if you change item cell color , it change all subitem color as the sme color
                                        // Unless if your change UseItemStyleForSubItems property of (lvi) ListViewItem to (false)
                                        lvi.BackColor = Color.Red;
                                    }
                                    lvsi.Text = dr.ItemArray[dt].ToString();
                                    lvi.Name = dr[dt].ToString();
                                    lvi.SubItems.Add(lvsi);

                                    lvi.ImageIndex = 1;
                                }



                                vw.Items.Add(lvi);
                                if (dr["Status"].ToString() == "")
                                {
                                    SystemSounds.Exclamation.Play();
                                }
                            }
                        }
                        Statistics();
                        CheckClientStatusInListView(ds);

                        vw.EndUpdate();
                    }
                    ds.Dispose();


                }
                catch (Exception ex)
                {
                    string strErr = ex.Message;

                }

                finally
                {
                }

            }

        }// end class filling

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            util = new Utilities();
            util.DeserializeDataSet(ref DataSetInfo);
            //DeserializeDataSet(ref DataSetInfo);

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void FillDGVClientInfo(ListView.SelectedListViewItemCollection ClientId)
        {

            Tawasol_Service Tawasol = new Tawasol_Service();

            string whr = " ";
            string CustomerId;
            string UserId;
            // string ClientId;
            string ValuesStr;


            CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();
            UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();

            // ClientId = item.Text;


            ValuesStr = CustomerId + "," + UserId + "," + ClientId[0].Text;
            DataSet ds = new DataSet();
            try
            {
                ds = Tawasol.RetreiveData_FromProcedure("sp_ListClientInfo", "@customerid,@UserId,@ClientId", "float,float,float", ValuesStr, whr);

                DataTable DGV_DT = new DataTable();
                DGV_DT.TableName = "Tabl";
                DataRow Dr;

                DataColumn Dc = new DataColumn();

                Dc.ColumnName = "Item";
                DGV_DT.Columns.Add(Dc);

                Dc = new DataColumn();
                Dc.ColumnName = "Item Value";
                DGV_DT.Columns.Add(Dc);

                Dr = DGV_DT.NewRow();

                lblClientName.Text = ds.Tables[0].Rows[0]["Contact_ID"].ToString();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Dr[0] = ds.Tables[0].Columns[0].ColumnName;
                    Dr[1] = ds.Tables[0].Rows[0][0].ToString();
                    DGV_DT.Rows.Add(Dr);


                    Dr = DGV_DT.NewRow();
                    Dr[0] = ds.Tables[0].Columns["Contact_ID"].ColumnName;
                    Dr[1] = ds.Tables[0].Rows[0]["Contact_ID"].ToString();
                    DGV_DT.Rows.Add(Dr);

                    Dr = DGV_DT.NewRow();
                    Dr[0] = ds.Tables[0].Columns["Ipaddress"].ColumnName;
                    Dr[1] = ds.Tables[0].Rows[0]["Ipaddress"].ToString();
                    DGV_DT.Rows.Add(Dr);

                    Dr = DGV_DT.NewRow();
                    Dr[0] = ds.Tables[0].Columns["Mobile"].ColumnName;
                    Dr[1] = ds.Tables[0].Rows[0]["Mobile"].ToString();
                    DGV_DT.Rows.Add(Dr);


                    Dr = DGV_DT.NewRow();
                    Dr[0] = ds.Tables[0].Columns["Email"].ColumnName;
                    Dr[1] = ds.Tables[0].Rows[0]["Email"].ToString();
                    DGV_DT.Rows.Add(Dr);

                }


                BindingSource bindSource = new BindingSource();
                bindSource.DataSource = DGV_DT;



                DGVClientInfo.DataSource = bindSource;



            }
            finally
            {
                ds.Clear();
                ds.Dispose();
            }
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuLogin = new System.Windows.Forms.MenuItem();
            this.mnuLogout = new System.Windows.Forms.MenuItem();
            this.mnuFileSeparator1 = new System.Windows.Forms.MenuItem();
            this.mnuSettings = new System.Windows.Forms.MenuItem();
            this.mnuProfile = new System.Windows.Forms.MenuItem();
            this.mnuFileSeparator2 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuControl = new System.Windows.Forms.MenuItem();
            this.mnuAcceptNextChat = new System.Windows.Forms.MenuItem();
            this.mnuNextResponse = new System.Windows.Forms.MenuItem();
            this.mnuAcceptChat = new System.Windows.Forms.MenuItem();
            this.mnuRefuseChat = new System.Windows.Forms.MenuItem();
            this.mnuControlSeparator1 = new System.Windows.Forms.MenuItem();
            this.mnuInvite = new System.Windows.Forms.MenuItem();
            this.mnuEngage = new System.Windows.Forms.MenuItem();
            this.mnuBlockForChat = new System.Windows.Forms.MenuItem();
            this.mnuSendPrivateMessage = new System.Windows.Forms.MenuItem();
            this.mnuChatActions = new System.Windows.Forms.MenuItem();
            this.mnuSubChatActionTransferChat = new System.Windows.Forms.MenuItem();
            this.mnuSubChatActionStopChat = new System.Windows.Forms.MenuItem();
            this.mnuSubChatActionPushPage = new System.Windows.Forms.MenuItem();
            this.mnuSubChatActionSendHTML = new System.Windows.Forms.MenuItem();
            this.mnuControlSeparator2 = new System.Windows.Forms.MenuItem();
            this.mnuChatHistory = new System.Windows.Forms.MenuItem();
            this.mnuAllSessionhistory = new System.Windows.Forms.MenuItem();
            this.mnuControlSeparator3 = new System.Windows.Forms.MenuItem();
            this.mnuCobrowse = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuToolbars = new System.Windows.Forms.MenuItem();
            this.mnuMainToolbars = new System.Windows.Forms.MenuItem();
            this.mnuFormatChatToolbars = new System.Windows.Forms.MenuItem();
            this.mnuStatusBar = new System.Windows.Forms.MenuItem();
            this.mnuAlwaysOnTop = new System.Windows.Forms.MenuItem();
            this.mnuSort = new System.Windows.Forms.MenuItem();
            this.mnuCustomize = new System.Windows.Forms.MenuItem();
            this.mnuViewSeparator1 = new System.Windows.Forms.MenuItem();
            this.mnuSelectNextItem = new System.Windows.Forms.MenuItem();
            this.mnuSelectPreviousItem = new System.Windows.Forms.MenuItem();
            this.mnuShowList = new System.Windows.Forms.MenuItem();
            this.mnuViewSeparator2 = new System.Windows.Forms.MenuItem();
            this.mnuFilter = new System.Windows.Forms.MenuItem();
            this.mnuTools = new System.Windows.Forms.MenuItem();
            this.mnuGenerateTags = new System.Windows.Forms.MenuItem();
            this.mnuAddEmailSignature = new System.Windows.Forms.MenuItem();
            this.mnuToolsSeparator1 = new System.Windows.Forms.MenuItem();
            this.mnuInformation = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuDashboard = new System.Windows.Forms.MenuItem();
            this.mnuOperator = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuHomePage = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuAdminConsole = new System.Windows.Forms.MenuItem();
            this.mnuChatTranscripts = new System.Windows.Forms.MenuItem();
            this.mnuKnowledgebase = new System.Windows.Forms.MenuItem();
            this.mnuSignUp = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuUpdate = new System.Windows.Forms.MenuItem();
            this.mnuCanned = new System.Windows.Forms.MenuItem();
            this.mnuModify = new System.Windows.Forms.MenuItem();
            this.mnuPopUp = new System.Windows.Forms.MenuItem();
            this.mnuCannedSeparator1 = new System.Windows.Forms.MenuItem();
            this.mnuMemorize = new System.Windows.Forms.MenuItem();
            this.mnuIntroductions = new System.Windows.Forms.MenuItem();
            this.mnuConversational = new System.Windows.Forms.MenuItem();
            this.mnuClosing = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuHelpTopics = new System.Windows.Forms.MenuItem();
            this.mnuHelpSeparator1 = new System.Windows.Forms.MenuItem();
            this.mnuGettingStartedandTraining = new System.Windows.Forms.MenuItem();
            this.mnuHelpSeparator2 = new System.Windows.Forms.MenuItem();
            this.mnuFrequentlyAskedQuestions = new System.Windows.Forms.MenuItem();
            this.mnuCustomerCenter = new System.Windows.Forms.MenuItem();
            this.mnuReportError = new System.Windows.Forms.MenuItem();
            this.mnuHelpSeparator3 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.ToolbarChat = new System.Windows.Forms.ToolBar();
            this.toolBarButton_TakeChat = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton_NextResponse = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton_Invite = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton_Engage = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton_UP = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton_Down = new System.Windows.Forms.ToolBarButton();
            this.imgToolbarChat = new System.Windows.Forms.ImageList(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.imgLvw_lstMessage = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVClientInfo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lstMessages = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TransferToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.HistoryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxFONT = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblConnectedClientName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblLytPnlTitlestaticals = new System.Windows.Forms.TableLayoutPanel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblWaitforChat = new System.Windows.Forms.Label();
            this.lblWaitforChatnumber = new System.Windows.Forms.Label();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.lblVisitorsinSite = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstvClients = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientInfo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tblLytPnlTitlestaticals.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 704);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuControl,
            this.mnuView,
            this.mnuTools,
            this.menuItem1,
            this.mnuCanned,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuLogin,
            this.mnuLogout,
            this.mnuFileSeparator1,
            this.mnuSettings,
            this.mnuProfile,
            this.mnuFileSeparator2,
            this.mnuExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Enabled = false;
            this.mnuLogin.Index = 0;
            this.mnuLogin.Text = "&Login ...";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Index = 1;
            this.mnuLogout.Text = "Log&out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuFileSeparator1
            // 
            this.mnuFileSeparator1.Index = 2;
            this.mnuFileSeparator1.Text = "-";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Index = 3;
            this.mnuSettings.Text = "&Setting";
            // 
            // mnuProfile
            // 
            this.mnuProfile.Index = 4;
            this.mnuProfile.Text = "&Profile";
            // 
            // mnuFileSeparator2
            // 
            this.mnuFileSeparator2.Index = 5;
            this.mnuFileSeparator2.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 6;
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuControl
            // 
            this.mnuControl.Index = 1;
            this.mnuControl.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAcceptNextChat,
            this.mnuNextResponse,
            this.mnuAcceptChat,
            this.mnuRefuseChat,
            this.mnuControlSeparator1,
            this.mnuInvite,
            this.mnuEngage,
            this.mnuBlockForChat,
            this.mnuSendPrivateMessage,
            this.mnuChatActions,
            this.mnuControlSeparator2,
            this.mnuChatHistory,
            this.mnuAllSessionhistory,
            this.mnuControlSeparator3,
            this.mnuCobrowse});
            this.mnuControl.Text = "&Control";
            // 
            // mnuAcceptNextChat
            // 
            this.mnuAcceptNextChat.Index = 0;
            this.mnuAcceptNextChat.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.mnuAcceptNextChat.Text = "&Accept Next Chat";
            // 
            // mnuNextResponse
            // 
            this.mnuNextResponse.Index = 1;
            this.mnuNextResponse.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.mnuNextResponse.Text = "&Next Response";
            // 
            // mnuAcceptChat
            // 
            this.mnuAcceptChat.Index = 2;
            this.mnuAcceptChat.Text = "Acce&ptChat";
            this.mnuAcceptChat.Click += new System.EventHandler(this.mnuAcceptChat_Click);
            // 
            // mnuRefuseChat
            // 
            this.mnuRefuseChat.Index = 3;
            this.mnuRefuseChat.Text = "&Refuse Chat";
            // 
            // mnuControlSeparator1
            // 
            this.mnuControlSeparator1.Index = 4;
            this.mnuControlSeparator1.Text = "-";
            // 
            // mnuInvite
            // 
            this.mnuInvite.Index = 5;
            this.mnuInvite.Text = "&Invite";
            // 
            // mnuEngage
            // 
            this.mnuEngage.Index = 6;
            this.mnuEngage.Text = "En&gage";
            // 
            // mnuBlockForChat
            // 
            this.mnuBlockForChat.Index = 7;
            this.mnuBlockForChat.Text = "&Block For Chat";
            this.mnuBlockForChat.Click += new System.EventHandler(this.mnuBlockForChat_Click);
            // 
            // mnuSendPrivateMessage
            // 
            this.mnuSendPrivateMessage.Index = 8;
            this.mnuSendPrivateMessage.Text = "Send Private &Message";
            // 
            // mnuChatActions
            // 
            this.mnuChatActions.Index = 9;
            this.mnuChatActions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSubChatActionTransferChat,
            this.mnuSubChatActionStopChat,
            this.mnuSubChatActionPushPage,
            this.mnuSubChatActionSendHTML});
            this.mnuChatActions.Text = "Chat Acti&ons";
            // 
            // mnuSubChatActionTransferChat
            // 
            this.mnuSubChatActionTransferChat.Index = 0;
            this.mnuSubChatActionTransferChat.Text = "&Transfer Chat";
            this.mnuSubChatActionTransferChat.Click += new System.EventHandler(this.mnuSubChatActionTransferChat_Click);
            // 
            // mnuSubChatActionStopChat
            // 
            this.mnuSubChatActionStopChat.Index = 1;
            this.mnuSubChatActionStopChat.Text = "&Stop Chat";
            this.mnuSubChatActionStopChat.Click += new System.EventHandler(this.mnuSubChatActionStopChat_Click);
            // 
            // mnuSubChatActionPushPage
            // 
            this.mnuSubChatActionPushPage.Index = 2;
            this.mnuSubChatActionPushPage.Text = "&Push Page";
            // 
            // mnuSubChatActionSendHTML
            // 
            this.mnuSubChatActionSendHTML.Index = 3;
            this.mnuSubChatActionSendHTML.Text = "Send &HTML";
            // 
            // mnuControlSeparator2
            // 
            this.mnuControlSeparator2.Index = 10;
            this.mnuControlSeparator2.Text = "-";
            // 
            // mnuChatHistory
            // 
            this.mnuChatHistory.Index = 11;
            this.mnuChatHistory.Text = "Chat &History";
            // 
            // mnuAllSessionhistory
            // 
            this.mnuAllSessionhistory.Index = 12;
            this.mnuAllSessionhistory.Text = "All Session Histor&y";
            // 
            // mnuControlSeparator3
            // 
            this.mnuControlSeparator3.Index = 13;
            this.mnuControlSeparator3.Text = "-";
            // 
            // mnuCobrowse
            // 
            this.mnuCobrowse.Index = 14;
            this.mnuCobrowse.Text = "Cobro&wse";
            // 
            // mnuView
            // 
            this.mnuView.Index = 2;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuToolbars,
            this.mnuStatusBar,
            this.mnuAlwaysOnTop,
            this.mnuSort,
            this.mnuCustomize,
            this.mnuViewSeparator1,
            this.mnuSelectNextItem,
            this.mnuSelectPreviousItem,
            this.mnuShowList,
            this.mnuViewSeparator2,
            this.mnuFilter});
            this.mnuView.Text = "&View";
            // 
            // mnuToolbars
            // 
            this.mnuToolbars.Index = 0;
            this.mnuToolbars.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuMainToolbars,
            this.mnuFormatChatToolbars});
            this.mnuToolbars.Text = "&Toolbars";
            // 
            // mnuMainToolbars
            // 
            this.mnuMainToolbars.Index = 0;
            this.mnuMainToolbars.Text = "&Main Toolbars";
            // 
            // mnuFormatChatToolbars
            // 
            this.mnuFormatChatToolbars.Index = 1;
            this.mnuFormatChatToolbars.Text = "&Format Chat Toolbars";
            // 
            // mnuStatusBar
            // 
            this.mnuStatusBar.Checked = true;
            this.mnuStatusBar.Index = 1;
            this.mnuStatusBar.Text = "&StatusBar";
            // 
            // mnuAlwaysOnTop
            // 
            this.mnuAlwaysOnTop.Index = 2;
            this.mnuAlwaysOnTop.Text = "A&lways On Top";
            // 
            // mnuSort
            // 
            this.mnuSort.Index = 3;
            this.mnuSort.Text = "S&ort";
            // 
            // mnuCustomize
            // 
            this.mnuCustomize.Index = 4;
            this.mnuCustomize.Text = "Customi&ze Columns...";
            // 
            // mnuViewSeparator1
            // 
            this.mnuViewSeparator1.Index = 5;
            this.mnuViewSeparator1.Text = "-";
            // 
            // mnuSelectNextItem
            // 
            this.mnuSelectNextItem.Index = 6;
            this.mnuSelectNextItem.Shortcut = System.Windows.Forms.Shortcut.AltDownArrow;
            this.mnuSelectNextItem.Text = "Select Ne&xt Item";
            // 
            // mnuSelectPreviousItem
            // 
            this.mnuSelectPreviousItem.Index = 7;
            this.mnuSelectPreviousItem.Shortcut = System.Windows.Forms.Shortcut.AltUpArrow;
            this.mnuSelectPreviousItem.Text = "Select &Previous Item";
            // 
            // mnuShowList
            // 
            this.mnuShowList.Index = 8;
            this.mnuShowList.Text = "Show &List";
            // 
            // mnuViewSeparator2
            // 
            this.mnuViewSeparator2.Index = 9;
            this.mnuViewSeparator2.Text = "-";
            // 
            // mnuFilter
            // 
            this.mnuFilter.Index = 10;
            this.mnuFilter.Text = "&Filter";
            // 
            // mnuTools
            // 
            this.mnuTools.Index = 3;
            this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuGenerateTags,
            this.mnuAddEmailSignature,
            this.mnuToolsSeparator1,
            this.mnuInformation});
            this.mnuTools.Text = "&Tools";
            // 
            // mnuGenerateTags
            // 
            this.mnuGenerateTags.Index = 0;
            this.mnuGenerateTags.Text = "Generate &Tags";
            // 
            // mnuAddEmailSignature
            // 
            this.mnuAddEmailSignature.Index = 1;
            this.mnuAddEmailSignature.Text = "Add Email &Signature";
            // 
            // mnuToolsSeparator1
            // 
            this.mnuToolsSeparator1.Index = 2;
            this.mnuToolsSeparator1.Text = "-";
            // 
            // mnuInformation
            // 
            this.mnuInformation.Index = 3;
            this.mnuInformation.Text = "&Information";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 4;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDashboard,
            this.mnuOperator,
            this.menuItem2,
            this.mnuHomePage,
            this.menuItem4,
            this.mnuAdminConsole,
            this.mnuChatTranscripts,
            this.mnuKnowledgebase,
            this.mnuSignUp,
            this.menuItem3,
            this.mnuUpdate});
            this.menuItem1.Text = "Ta&wasol";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Index = 0;
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuOperator
            // 
            this.mnuOperator.Index = 1;
            this.mnuOperator.Shortcut = System.Windows.Forms.Shortcut.F8;
            this.mnuOperator.Text = "Operator Snapshot";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // mnuHomePage
            // 
            this.mnuHomePage.Index = 3;
            this.mnuHomePage.Text = "HomePage";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "-";
            // 
            // mnuAdminConsole
            // 
            this.mnuAdminConsole.Index = 5;
            this.mnuAdminConsole.Text = "Admin Console";
            // 
            // mnuChatTranscripts
            // 
            this.mnuChatTranscripts.Index = 6;
            this.mnuChatTranscripts.Text = "Chat Transcripts";
            // 
            // mnuKnowledgebase
            // 
            this.mnuKnowledgebase.Index = 7;
            this.mnuKnowledgebase.Text = "Knowledgebase";
            // 
            // mnuSignUp
            // 
            this.mnuSignUp.Index = 8;
            this.mnuSignUp.Text = "Sign Up";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 9;
            this.menuItem3.Text = "-";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Index = 10;
            this.mnuUpdate.Text = "Update";
            // 
            // mnuCanned
            // 
            this.mnuCanned.Index = 5;
            this.mnuCanned.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuModify,
            this.mnuPopUp,
            this.mnuCannedSeparator1,
            this.mnuMemorize,
            this.mnuIntroductions,
            this.mnuConversational,
            this.mnuClosing});
            this.mnuCanned.Text = "&Canned";
            // 
            // mnuModify
            // 
            this.mnuModify.Index = 0;
            this.mnuModify.Text = "&Modify";
            // 
            // mnuPopUp
            // 
            this.mnuPopUp.Index = 1;
            this.mnuPopUp.Text = "&PopUp";
            // 
            // mnuCannedSeparator1
            // 
            this.mnuCannedSeparator1.Index = 2;
            this.mnuCannedSeparator1.Text = "-";
            // 
            // mnuMemorize
            // 
            this.mnuMemorize.Index = 3;
            this.mnuMemorize.Text = "&Memorize";
            // 
            // mnuIntroductions
            // 
            this.mnuIntroductions.Index = 4;
            this.mnuIntroductions.Text = "&Introductions";
            // 
            // mnuConversational
            // 
            this.mnuConversational.Index = 5;
            this.mnuConversational.Text = "Con&versational";
            // 
            // mnuClosing
            // 
            this.mnuClosing.Index = 6;
            this.mnuClosing.Text = "&Closing";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 6;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuHelpTopics,
            this.mnuHelpSeparator1,
            this.mnuGettingStartedandTraining,
            this.mnuHelpSeparator2,
            this.mnuFrequentlyAskedQuestions,
            this.mnuCustomerCenter,
            this.mnuReportError,
            this.mnuHelpSeparator3,
            this.mnuAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpTopics
            // 
            this.mnuHelpTopics.Index = 0;
            this.mnuHelpTopics.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.mnuHelpTopics.Text = "&HelpTopics";
            // 
            // mnuHelpSeparator1
            // 
            this.mnuHelpSeparator1.Index = 1;
            this.mnuHelpSeparator1.Text = "-";
            // 
            // mnuGettingStartedandTraining
            // 
            this.mnuGettingStartedandTraining.Index = 2;
            this.mnuGettingStartedandTraining.Text = "&Getting Startedand Training";
            // 
            // mnuHelpSeparator2
            // 
            this.mnuHelpSeparator2.Index = 3;
            this.mnuHelpSeparator2.Text = "-";
            // 
            // mnuFrequentlyAskedQuestions
            // 
            this.mnuFrequentlyAskedQuestions.Index = 4;
            this.mnuFrequentlyAskedQuestions.Text = "&Frequently Asked Questions";
            // 
            // mnuCustomerCenter
            // 
            this.mnuCustomerCenter.Index = 5;
            this.mnuCustomerCenter.Text = "&Customer Center";
            // 
            // mnuReportError
            // 
            this.mnuReportError.Index = 6;
            this.mnuReportError.Text = "&Report Error";
            // 
            // mnuHelpSeparator3
            // 
            this.mnuHelpSeparator3.Index = 7;
            this.mnuHelpSeparator3.Text = "-";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 8;
            this.mnuAbout.Tag = "";
            this.mnuAbout.Text = "&About...";
            // 
            // ToolbarChat
            // 
            this.ToolbarChat.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.ToolbarChat.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton_TakeChat,
            this.toolBarButton_NextResponse,
            this.toolBarButton_Invite,
            this.toolBarButton_Engage,
            this.toolBarButton_UP,
            this.toolBarButton_Down});
            this.ToolbarChat.DropDownArrows = true;
            this.ToolbarChat.ImageList = this.imgToolbarChat;
            this.ToolbarChat.Location = new System.Drawing.Point(0, 0);
            this.ToolbarChat.Name = "ToolbarChat";
            this.ToolbarChat.ShowToolTips = true;
            this.ToolbarChat.Size = new System.Drawing.Size(977, 28);
            this.ToolbarChat.TabIndex = 13;
            this.ToolbarChat.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.ToolbarChat.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.ToolbarChat_ButtonClick);
            // 
            // toolBarButton_TakeChat
            // 
            this.toolBarButton_TakeChat.ImageIndex = 0;
            this.toolBarButton_TakeChat.Name = "toolBarButton_TakeChat";
            this.toolBarButton_TakeChat.Text = "Take Chat";
            // 
            // toolBarButton_NextResponse
            // 
            this.toolBarButton_NextResponse.ImageIndex = 1;
            this.toolBarButton_NextResponse.Name = "toolBarButton_NextResponse";
            this.toolBarButton_NextResponse.Text = "Next Response";
            // 
            // toolBarButton_Invite
            // 
            this.toolBarButton_Invite.ImageIndex = 3;
            this.toolBarButton_Invite.Name = "toolBarButton_Invite";
            this.toolBarButton_Invite.Text = "Invite";
            // 
            // toolBarButton_Engage
            // 
            this.toolBarButton_Engage.ImageIndex = 4;
            this.toolBarButton_Engage.Name = "toolBarButton_Engage";
            this.toolBarButton_Engage.Text = "Engage";
            // 
            // toolBarButton_UP
            // 
            this.toolBarButton_UP.ImageIndex = 5;
            this.toolBarButton_UP.Name = "toolBarButton_UP";
            this.toolBarButton_UP.Text = "Up";
            // 
            // toolBarButton_Down
            // 
            this.toolBarButton_Down.ImageIndex = 2;
            this.toolBarButton_Down.Name = "toolBarButton_Down";
            this.toolBarButton_Down.Text = "Down";
            // 
            // imgToolbarChat
            // 
            this.imgToolbarChat.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolbarChat.ImageStream")));
            this.imgToolbarChat.TransparentColor = System.Drawing.Color.Transparent;
            this.imgToolbarChat.Images.SetKeyName(0, "");
            this.imgToolbarChat.Images.SetKeyName(1, "");
            this.imgToolbarChat.Images.SetKeyName(2, "");
            this.imgToolbarChat.Images.SetKeyName(3, "");
            this.imgToolbarChat.Images.SetKeyName(4, "");
            this.imgToolbarChat.Images.SetKeyName(5, "");
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 661);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(977, 32);
            this.statusBar1.TabIndex = 14;
            this.statusBar1.Text = "statusBar1";
            // 
            // imgLvw_lstMessage
            // 
            this.imgLvw_lstMessage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLvw_lstMessage.ImageStream")));
            this.imgLvw_lstMessage.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLvw_lstMessage.Images.SetKeyName(0, "Stoplight_Single0.gif");
            this.imgLvw_lstMessage.Images.SetKeyName(1, "Stoplight_Single1.gif");
            this.imgLvw_lstMessage.Images.SetKeyName(2, "Stoplight_Single2.gif");
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(226, 266);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVClientInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(218, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVClientInfo
            // 
            this.DGVClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientInfo.ColumnHeadersVisible = false;
            this.DGVClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVClientInfo.Location = new System.Drawing.Point(3, 3);
            this.DGVClientInfo.Name = "DGVClientInfo";
            this.DGVClientInfo.RowHeadersVisible = false;
            this.DGVClientInfo.Size = new System.Drawing.Size(212, 234);
            this.DGVClientInfo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(218, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblInfo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(723, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357143F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.64286F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 361);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(228, 19);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Info";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 224);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(960, 367);
            this.tableLayoutPanel3.TabIndex = 40;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel4.Controls.Add(this.lstMessages, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtMessage, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnSendMsg, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.toolStripContainer1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.toolStripContainer2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(714, 361);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // lstMessages
            // 
            this.lstMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMessages.Location = new System.Drawing.Point(3, 56);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.ReadOnly = true;
            this.lstMessages.Size = new System.Drawing.Size(658, 210);
            this.lstMessages.TabIndex = 19;
            this.lstMessages.Text = "";
            this.lstMessages.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.lstMessages_ControlRemoved);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(3, 304);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(658, 54);
            this.txtMessage.TabIndex = 20;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendMsg.Location = new System.Drawing.Point(667, 335);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(44, 23);
            this.btnSendMsg.TabIndex = 16;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(658, 2);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 23);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(658, 27);
            this.toolStripContainer1.TabIndex = 21;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransferToolStripButton,
            this.StopToolStripButton,
            this.toolStripSeparator,
            this.HistoryToolStripButton,
            this.toolStripSeparator2,
            this.printToolStripButton,
            this.cutToolStripButton,
            this.toolStripSeparator3,
            this.copyToolStripButton,
            this.toolStripSeparator4,
            this.pasteToolStripButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(337, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // TransferToolStripButton
            // 
            this.TransferToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferToolStripButton.Image")));
            this.TransferToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TransferToolStripButton.Name = "TransferToolStripButton";
            this.TransferToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.TransferToolStripButton.Text = "&Transfer";
            this.TransferToolStripButton.ToolTipText = "Transfer";
            // 
            // StopToolStripButton
            // 
            this.StopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("StopToolStripButton.Image")));
            this.StopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopToolStripButton.Name = "StopToolStripButton";
            this.StopToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.StopToolStripButton.Text = "&Stop";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // HistoryToolStripButton
            // 
            this.HistoryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryToolStripButton.Image")));
            this.HistoryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryToolStripButton.Name = "HistoryToolStripButton";
            this.HistoryToolStripButton.Size = new System.Drawing.Size(65, 22);
            this.HistoryToolStripButton.Text = "&History";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(658, 1);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(3, 272);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(658, 26);
            this.toolStripContainer2.TabIndex = 22;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxFONT,
            this.toolStripComboBoxFontSize,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton1,
            this.toolStripSeparator1,
            this.cutToolStripButton1,
            this.copyToolStripButton1,
            this.pasteToolStripButton1,
            this.toolStripSeparator5,
            this.helpToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(658, 1);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripComboBoxFONT
            // 
            this.toolStripComboBoxFONT.Name = "toolStripComboBoxFONT";
            this.toolStripComboBoxFONT.Size = new System.Drawing.Size(121, 1);
            // 
            // toolStripComboBoxFontSize
            // 
            this.toolStripComboBoxFontSize.Name = "toolStripComboBoxFontSize";
            this.toolStripComboBoxFontSize.Size = new System.Drawing.Size(75, 1);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 0);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 0);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 0);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton1
            // 
            this.printToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton1.Image")));
            this.printToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton1.Name = "printToolStripButton1";
            this.printToolStripButton1.Size = new System.Drawing.Size(23, 0);
            this.printToolStripButton1.Text = "&Print";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 1);
            // 
            // cutToolStripButton1
            // 
            this.cutToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton1.Image")));
            this.cutToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton1.Name = "cutToolStripButton1";
            this.cutToolStripButton1.Size = new System.Drawing.Size(23, 0);
            this.cutToolStripButton1.Text = "C&ut";
            // 
            // copyToolStripButton1
            // 
            this.copyToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton1.Image")));
            this.copyToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton1.Name = "copyToolStripButton1";
            this.copyToolStripButton1.Size = new System.Drawing.Size(23, 0);
            this.copyToolStripButton1.Text = "&Copy";
            // 
            // pasteToolStripButton1
            // 
            this.pasteToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton1.Image")));
            this.pasteToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton1.Name = "pasteToolStripButton1";
            this.pasteToolStripButton1.Size = new System.Drawing.Size(23, 0);
            this.pasteToolStripButton1.Text = "&Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 1);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 0);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClientName);
            this.panel1.Controls.Add(this.lblConnectedClientName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 14);
            this.panel1.TabIndex = 23;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblClientName.Location = new System.Drawing.Point(64, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(49, 13);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "              ";
            // 
            // lblConnectedClientName
            // 
            this.lblConnectedClientName.AutoSize = true;
            this.lblConnectedClientName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConnectedClientName.Location = new System.Drawing.Point(0, 0);
            this.lblConnectedClientName.Name = "lblConnectedClientName";
            this.lblConnectedClientName.Size = new System.Drawing.Size(64, 13);
            this.lblConnectedClientName.TabIndex = 0;
            this.lblConnectedClientName.Text = "Client Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstvClients, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 184);
            this.tableLayoutPanel1.TabIndex = 41;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.tblLytPnlTitlestaticals);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 29);
            this.panel2.TabIndex = 4;
            // 
            // tblLytPnlTitlestaticals
            // 
            this.tblLytPnlTitlestaticals.AutoSize = true;
            this.tblLytPnlTitlestaticals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLytPnlTitlestaticals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblLytPnlTitlestaticals.ColumnCount = 11;
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tblLytPnlTitlestaticals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblLytPnlTitlestaticals.Controls.Add(this.lblFilter, 0, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.comboBox1, 1, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.lblWaitforChat, 5, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.lblWaitforChatnumber, 6, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.lblVisitors, 3, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.lblVisitorsinSite, 4, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.cboState, 9, 0);
            this.tblLytPnlTitlestaticals.Controls.Add(this.lblStatus, 8, 0);
            this.tblLytPnlTitlestaticals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPnlTitlestaticals.ForeColor = System.Drawing.Color.White;
            this.tblLytPnlTitlestaticals.Location = new System.Drawing.Point(0, 0);
            this.tblLytPnlTitlestaticals.Name = "tblLytPnlTitlestaticals";
            this.tblLytPnlTitlestaticals.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tblLytPnlTitlestaticals.RowCount = 1;
            this.tblLytPnlTitlestaticals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPnlTitlestaticals.Size = new System.Drawing.Size(951, 29);
            this.tblLytPnlTitlestaticals.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(3, 6);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(56, 23);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblWaitforChat
            // 
            this.lblWaitforChat.AutoSize = true;
            this.lblWaitforChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaitforChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitforChat.Location = new System.Drawing.Point(476, 6);
            this.lblWaitforChat.Name = "lblWaitforChat";
            this.lblWaitforChat.Size = new System.Drawing.Size(101, 23);
            this.lblWaitforChat.TabIndex = 2;
            this.lblWaitforChat.Text = "Wait for Chat";
            // 
            // lblWaitforChatnumber
            // 
            this.lblWaitforChatnumber.AutoSize = true;
            this.lblWaitforChatnumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWaitforChatnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitforChatnumber.Location = new System.Drawing.Point(583, 6);
            this.lblWaitforChatnumber.Name = "lblWaitforChatnumber";
            this.lblWaitforChatnumber.Size = new System.Drawing.Size(14, 23);
            this.lblWaitforChatnumber.TabIndex = 3;
            this.lblWaitforChatnumber.Text = "0";
            // 
            // lblVisitors
            // 
            this.lblVisitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisitors.AutoSize = true;
            this.lblVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitors.Location = new System.Drawing.Point(283, 6);
            this.lblVisitors.Name = "lblVisitors";
            this.lblVisitors.Size = new System.Drawing.Size(100, 23);
            this.lblVisitors.TabIndex = 4;
            this.lblVisitors.Text = "Visitors in Site:";
            // 
            // lblVisitorsinSite
            // 
            this.lblVisitorsinSite.AutoSize = true;
            this.lblVisitorsinSite.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVisitorsinSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorsinSite.Location = new System.Drawing.Point(389, 6);
            this.lblVisitorsinSite.Name = "lblVisitorsinSite";
            this.lblVisitorsinSite.Size = new System.Drawing.Size(14, 23);
            this.lblVisitorsinSite.TabIndex = 5;
            this.lblVisitorsinSite.Text = "0";
            // 
            // cboState
            // 
            this.cboState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(788, 9);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(108, 21);
            this.cboState.TabIndex = 7;
            this.cboState.Text = "OnLine";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(738, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lstvClients
            // 
            this.lstvClients.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lstvClients.AllowColumnReorder = true;
            this.lstvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvClients.FullRowSelect = true;
            this.lstvClients.GridLines = true;
            this.lstvClients.HideSelection = false;
            this.lstvClients.Location = new System.Drawing.Point(3, 38);
            this.lstvClients.MultiSelect = false;
            this.lstvClients.Name = "lstvClients";
            this.lstvClients.ShowGroups = false;
            this.lstvClients.Size = new System.Drawing.Size(951, 143);
            this.lstvClients.SmallImageList = this.imgLvw_lstMessage;
            this.lstvClients.StateImageList = this.imgLvw_lstMessage;
            this.lstvClients.TabIndex = 3;
            this.lstvClients.UseCompatibleStateImageBehavior = false;
            this.lstvClients.View = System.Windows.Forms.View.Details;
            this.lstvClients.SelectedIndexChanged += new System.EventHandler(this.lstvClients_SelectedIndexChanged_1);
            this.lstvClients.DoubleClick += new System.EventHandler(this.lstvClients_DoubleClick);
            this.lstvClients.Click += new System.EventHandler(this.lstvClients_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(977, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.ToolbarChat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.textBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Tawasol Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientInfo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tblLytPnlTitlestaticals.ResumeLayout(false);
            this.tblLytPnlTitlestaticals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        private void EnabledDisabledControls(bool ChkVal, int stage)
        {
            switch (stage)
            {
                case 1:
                    btnSendMsg.Enabled = ChkVal;
                    mnuSubChatActionStopChat.Enabled = ChkVal;
                    break;

                case 2:
                    mnuBlockForChat.Enabled = ChkVal;
                    break;

            }


        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            EnabledDisabledControls(false, 1);
            EnabledDisabledControls(false, 2);

            Tawasol_Service Tawasol = new Tawasol_Service();
            string CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();

            DataSet dss = Tawasol.RetreiveData_FromProcedure("sp_ListView", "@customerid", "float", CustomerId, "All");

            lstvClients.Clear();
            lstvClients.Sorting = System.Windows.Forms.SortOrder.Ascending;

            lstvClients.BeginUpdate();


            foreach (DataColumn dc in dss.Tables[0].Columns)
            {
                ColumnHeader colh = new ColumnHeader();
                colh.Name = dc.ColumnName;
                colh.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                colh.Text = dc.ColumnName;
                lstvClients.Columns.Add(colh);
            }

            dss.Clear();
            dss.Dispose();

            lstvClients.EndUpdate();

            this.backgroundWorker1.RunWorkerAsync();

            lstvClients.Sort();
        }

        private void ShowMessages()
        {


            Tawasol_Service Tawasol = new Tawasol_Service();

            DataSet Ds = new DataSet();



            string IpAddress;

            ListView.SelectedIndexCollection indexes = this.lstvClients.SelectedIndices;

            if (indexes.Count <= 0)
            {
                return;
            }

            IpAddress = lstvClients.FocusedItem.Text;

            Ds = Tawasol.RetreiveData_FromProcedure("ShowChatMessages", "", "", "", "ClientId=" + IpAddress);


            string strmsgs;
            strmsgs = "";
            Color AQ = new Color();

            int Ic = -1;




            if (Ds.Tables.Count > 0)
            {
                if (Ds.Tables[0].Rows.Count > 0 && Ds.Tables[0].Columns.Count > 0)
                {
                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        strmsgs += Ds.Tables[0].Rows[i]["AnswrQuest"].ToString() + '\n';

                    }

                    lstMessages.Text = strmsgs;


                    for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                    {
                        strmsgs = Ds.Tables[0].Rows[i]["AnswrQuest"].ToString();
                        lstMessages.Find(strmsgs);

                        if (Ic > -1)
                        {
                            AQ = Color.Red;

                        }
                        else
                        { AQ = Color.Green; }

                        Ic *= -1;

                        lstMessages.SelectionFont = new Font("Verdana", 12, FontStyle.Regular);
                        lstMessages.SelectionColor = AQ;
                    }
                }

            }






            Ds.Dispose();




        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();

            if (textBox1.Text == "1")
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                textBox1.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                ExecRefersh();
                string msg = String.Format("{0}", e.Result);
                textBox1.Text = msg;
                this.backgroundWorker1.CancelAsync();
            }


        }

        private void Take_Chat()
        {

            if (lstvClients.SelectedItems.Count > 0)
            {
                if (lstvClients.FocusedItem.SubItems[3].Text.ToLower() != "chatting")
                {
                    ChangeClientState();

                    EnabledDisabledControls(true, 1);
                }
            }
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

        protected string MessagesAfterConnect()
        {
            DataSet DsMsg = new DataSet();
            string WelComeLetter = string.Empty;

            Tawasol_Service Tawasol = new Tawasol_Service();
            string CustomerId, languageId;
            languageId = "2";

            CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();


            string paramValues = CustomerId + "," + languageId + ",1,WelComeMessage";

            DsMsg = Tawasol.RetreiveData_FromProcedure("Sp_RetrieveSystemMessages", "@customerId ,@languageId,@MessageTypeId,@MessageName", "int,int,int,string", paramValues, string.Empty);


            if (CheckDataSet(DsMsg))
            {
                WelComeLetter = DsMsg.Tables[0].Rows[0][0].ToString();
            }

            return WelComeLetter;
        }


        private void ChangeClientState()
        {
            string StrColumnsName = "";
            string StrColumnsValues = "";

            foreach (DataRow dr in DataSetInfo.Tables[0].Rows)
            {
                foreach (DataColumn dc in dr.Table.Columns)
                {
                    if (dc.ColumnName == "CustomerId" || dc.ColumnName == "userId")
                    {
                        StrColumnsName += dc.ColumnName + ",";
                        StrColumnsValues += dr[dc.Ordinal].ToString() + ",";
                    }
                }
            }

            StrColumnsName += "ClientId" + ",";
            StrColumnsValues += lstvClients.FocusedItem.Text + ",";

            string AnswerText, AnswerDate, AnswerType, SessionId, MessageId, AnswerTime;

            //Message to Client To start chating , Always it's Id is (1) .

            AnswerText = "'" + MessagesAfterConnect() + "'";

            AnswerDate = "'" + System.DateTime.Now.ToString() + "'";
            AnswerTime = "'" + System.DateTime.Now.ToString() + "'";


            AnswerType = "0"; // when AnserType =0 means That's answer is Welcome letter


            Tawasol_Service Tawasol = new Tawasol_Service();

            //==============================================================================		
            //if SessionState is (0) That's Mean that Session is OPEN
            //if SessionState is (1) That's Mean that Session is CLOSE

            //INSERT TO SESSION
            Tawasol.InsertData("tblSession", StrColumnsName + "Startdate,StartTime,SessionState", StrColumnsValues + AnswerDate + "," + AnswerTime + ",0");

            //================================================================================


            DataSet ds = new DataSet();

            //GET LAST NUMBER OF SEESION
            ds = Tawasol.GetAggregate("TblSession", "SessionId", "", 1);

            SessionId = ds.Tables[0].Rows[0][0].ToString();

            //INSERT TO SESSION History
            Tawasol.InsertData("tblSessionHistory", StrColumnsName + "Startdate,StartTime,SessionState,SessionId", StrColumnsValues + AnswerDate + "," + AnswerTime + ",0," + SessionId);

            MessageId = "1"; // Message Counter for each Client

            //INSERT TO SupportAnswers
            Tawasol.InsertData("TblSupportAnswers", StrColumnsName + "SessionId,MessageId,AnswerText,AnswerDate,AnswerType", StrColumnsValues + SessionId + "," + MessageId + "," + AnswerText + "," + AnswerDate + "," + AnswerType);

            //==================================
            string ClientId = lstvClients.SelectedItems[0].Text;
            int y = (int)StatusClient.Client_Handle;
            string cmsg = "clientId = " + ClientId;
            //UPDATE TO CLIENT TABLE
            Tawasol.UpdateData("TblClientele", "Status", y.ToString(), cmsg);

            int ClientIdi = Convert.ToInt32(lstvClients.SelectedIndices[0]);
            lstvClients.Items.Remove(lstvClients.Items[ClientIdi]);





            //FILL  LISTVIEW
            Filling fill = new Filling(lstvClients, lblWaitforChatnumber, lblVisitorsinSite);

            // THREAD			
            this.backgroundWorker1.RunWorkerAsync();
            lstvClients.Sort();

            ds.Dispose();

        }

        //private void playSoundFromResource()
        //{
        //    string path = Application.StartupPath + @"\sounds\";

        //    SoundPlayer sndPing = new SoundPlayer(path + "chatcome.wma");
        //    sndPing.Play();
        //}

        private void button2_Click(object sender, System.EventArgs e)
        {
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
        }

        private void mnuNewFile_Click(object sender, System.EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void ToolbarChat_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            switch (ToolbarChat.Buttons.IndexOf(e.Button))
            {
                case 0: // Take Chat
                    Take_Chat();
                    break;
            }
        }

        private void CheckMessages(ref string Msg)
        {
            string[] Specialchar1 = { "," };
            string[] Specialchar2 = { " " };

            for (int i = 0; i < Specialchar1.Length; i++)
            {
                if (Msg.IndexOf(Specialchar1[i]) > 0)
                {
                    Msg = Msg.Replace(Specialchar1[i], Specialchar2[i]);
                }

            }
        }



        private void SendMessage()
        {

            string AnswerText,
                    AnswerDate,
                    AnswerType,
                    SessionId,
                    MessageId,
                    AnswerTime,
                    ClientId,
                    UserId,
                    CustomerId, Msg;

            //============================================================================
            string StrColumnsName = string.Empty; ;
            string StrColumnsValues = string.Empty; ;


            foreach (DataRow dr in DataSetInfo.Tables[0].Rows)
            {
                foreach (DataColumn dc in dr.Table.Columns)
                {
                    if (dc.ColumnName == "CustomerId" || dc.ColumnName == "userId")
                    {
                        StrColumnsName += dc.ColumnName + ",";
                        StrColumnsValues += dr[dc.Ordinal].ToString() + ",";
                    }
                }
            }

            StrColumnsName += "ClientId" + ",";
            StrColumnsValues += lstvClients.FocusedItem.Text + ",";


            //---------------------------------------------------------------------------


            //Message to Client To start chating , Always it's Id is (1) .
            Msg = txtMessage.Text;

            //Replace Special Characters
            CheckMessages(ref Msg);


            AnswerText = "'" + Msg + "'";
            AnswerDate = "'" + System.DateTime.Now.ToString() + "'";
            AnswerTime = "'" + System.DateTime.Now.ToString() + "'";
            AnswerType = "1"; // AswerType =1 Mean this Answer But when it equal 0 means that is welcome message




            ClientId = lstvClients.FocusedItem.Text;
            UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();
            CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();

            string WhrCondition;

            Tawasol_Service Tawasol = new Tawasol_Service();

            //if SessionState is (0) That's Main that Session is OPEN
            //if SessionState is (1) That's Main that Session is CLOSE

            //INSERT TO SESSION
            //Tawasol.InsertData("tblSession", StrColumnsName + "Statdate,StartTime,SessionState", StrColumnsValues + AnswerDate + "," + AnswerTime + ",0");

            DataSet ds = new DataSet();

            WhrCondition = " ClientId=" + ClientId + " and " +
                           " CustomerId=" + CustomerId + " and " +
                           " UserId =" + UserId + " and SessionState =0";

            //GET LAST NUMBER OF SEESION
            ds = Tawasol.RetrieveData("TblSession", "SessionId", WhrCondition, null);

            SessionId = ds.Tables[0].Rows[1][0].ToString();

            ds.Dispose();

            WhrCondition = " ClientId=" + ClientId + " and " +
                            " CustomerId=" + CustomerId + " and " +
                            " UserId =" + UserId + " and " +
                            " SessionId=" + SessionId;

            ds = new DataSet();

            ds = Tawasol.GetAggregate("TblSupportAnswers", "MessageId", WhrCondition, 1);

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

            //INSERT TO SupportAnswers
            Tawasol.InsertData("TblSupportAnswers", StrColumnsName + "SessionId,MessageId,AnswerText,AnswerDate,AnswerType,AnswerTime", StrColumnsValues + SessionId + "," + MessageId + "," + AnswerText + "," + AnswerDate + "," + AnswerType + "," + AnswerTime);

            txtMessage.Text = string.Empty;
        }
        private void btnSendMsg_Click(object sender, System.EventArgs e)
        {
            if (txtMessage.Text.Length > 0)
            {
                SendMessage();
            }

        }

        private void lstvClients_DoubleClick(object sender, System.EventArgs e)
        {
            Take_Chat();
        }

        private void lstvClients_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FillDGVClientInfo(((ListView)sender).SelectedItems);
            EnabledDisabledControls(true, 2);
        }



        private void ExecRefersh()
        {
            Filling fill = new Filling(lstvClients, lblWaitforChatnumber, lblVisitorsinSite);


            fill.FillListView();

        }

        private void Form1_Closed(object sender, System.EventArgs e)
        {
            DataSetInfo.Dispose();
        }

        private void lstMessages_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                e.Result = 1;
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                textBox1.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                ShowMessages();
                string msg = String.Format("{0}", e.Result);
                textBox1.Text = msg;
                this.backgroundWorker2.CancelAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = 0;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BlockClient()
        {
            string ClientId,
                         UserId,
                         CustomerId;

            ClientId = lstvClients.FocusedItem.Text;
            UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();
            CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();

            string WhrCondition;

            Tawasol_Service Tawasol = new Tawasol_Service();

            WhrCondition = " ClientId=" + ClientId + " and " +
                          " CustomerId=" + CustomerId;


            //==================================

            int y = (int)StatusClient.Client_Block;

            //UPDATE TO CLIENT TABLE
            Tawasol.UpdateData("TblClientele", "Status", y.ToString(), WhrCondition);

            int ClientIdi = Convert.ToInt32(lstvClients.SelectedIndices[0]);
            lstvClients.Items.Remove(lstvClients.Items[ClientIdi]);
            //==========================

            txtMessage.Text = string.Empty;
            lstMessages.Text = string.Empty;
            DGVClientInfo.DataSource = null;

            ClearControls();

        }


        private void CloseClientChatting()
        {
            string ClientId,
                      UserId,
                      CustomerId;

            ClientId = lstvClients.FocusedItem.Text;
            UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();
            CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();

            string WhrCondition;

            Tawasol_Service Tawasol = new Tawasol_Service();

            //if SessionState is (0) That's Main that Session is OPEN
            //if SessionState is (1) That's Main that Session is CLOSE

            DataSet ds = new DataSet();

            WhrCondition = " ClientId=" + ClientId + " and " +
                           " CustomerId=" + CustomerId + " and " +
                           " UserId =" + UserId + " and SessionState=0";

            //GET LAST NUMBER OF SEESION
            Tawasol.UpdateData("TblSession", "SessionState,Enddate", "1,'" + DateTime.Now + "'", WhrCondition);
            ds.Dispose();

            //==================================

            int y = (int)StatusClient.Client_Close;
            string cmsg = "clientId = " + ClientId;
            //UPDATE TO CLIENT TABLE
            Tawasol.UpdateData("TblClientele", "Status", y.ToString(), cmsg);

            int ClientIdi = Convert.ToInt32(lstvClients.SelectedIndices[0]);
            lstvClients.Items.Remove(lstvClients.Items[ClientIdi]);

            //==========================
            ClearControls();
        }


        private void ClearControls()
        {
            DGVClientInfo.DataSource = null;
            txtMessage.Text = string.Empty;
            lstMessages.Text = string.Empty;

        }


        private void mnuBlockForChat_Click(object sender, EventArgs e)
        {
            if (lstvClients.SelectedItems.Count != 0)
            {
                BlockClient();
            }

        }

        private void mnuSubChatActionStopChat_Click(object sender, EventArgs e)
        {

            if (lstvClients.SelectedItems.Count != 0)
            {
                CloseClientChatting();
            }

        }

        private void lstMessages_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void lstvClients_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void mnuSubChatActionTransferChat_Click(object sender, EventArgs e)
        {

            frmTransferClientsBetweenOperators frmTr = new frmTransferClientsBetweenOperators();

            frmTr.Show();

        }

        private void mnuAcceptChat_Click(object sender, EventArgs e)
        {
            Tawasol_Service Tawsol = new Tawasol_Service();
            string whr;
            DataSet dbsession = new DataSet();
            string ClientId = lstvClients.FocusedItem.Text;


            //Transfer_To (current User)
            string UserId = DataSetInfo.Tables[0].Rows[0]["UserId"].ToString();

            //Transfer_From (Come From)
            string UserId_Transfer_From = lstvClients.SelectedItems[0].SubItems[13].Text;

            string CustomerId = DataSetInfo.Tables[0].Rows[0]["CustomerId"].ToString();

            string SessionId = lstvClients.SelectedItems[0].SubItems[12].Text;

            whr = "CustomerId=" + CustomerId +
                " and UserId=" + UserId_Transfer_From +
                " and ClientId=" + ClientId +
                " and SessionId=" + SessionId;

            string SessionState = ((int)SessionStatus.ContinueWithAnotherUser).ToString();
            string _TransferStatus = ((int)TransferStatus.Accept).ToString();

            string StrColumnsName = string.Empty;
            string StrColumnsValues = string.Empty;

            //  first Update Enddate of Session between Previous User if tblSessionHistory
            Tawsol.UpdateData("tblsessionHistory", "EndDate,SessionState,TransferStatus", "'" + DateTime.Now.ToString() + "'," + SessionState + "," + _TransferStatus, whr);

            //--------------------------------------------------

            //Secondly 
            //Update UserId in TblSession
            string Tstatus = ((int)TransferStatus.Accept).ToString();
            Tawsol.UpdateData("tblsession", "UserId,UserId_ToBeTransferTo,ToTransfer", UserId + ",0," + Tstatus, whr);

            //--------------------------------------------------


            //Thirdly Add another record into tblsessionHistory to register next session between current client with another user
            //INSERT TO SESSION History Table

            // Retrive Session Info for Session To be insert into session History                
            dbsession = Tawsol.RetreiveData_FromProcedure("SessionInfo", "@SessionId", "int", SessionId, string.Empty);

            // check dataset validity and prepare columns names and value for insert operation
            if (CheckDataSet(dbsession))
            {
                foreach (DataRow dr in dbsession.Tables[0].Rows)
                {
                    foreach (DataColumn dc in dbsession.Tables[0].Columns)
                    {
                        if (dr[dc.ColumnName] != null && dr[dc.ColumnName].ToString() != string.Empty)
                        {
                            StrColumnsName += dc.ColumnName + ",";

                            if (dr[dc.ColumnName].GetType() == DateTime.Now.GetType())
                            {
                                StrColumnsValues += "'" + dr[dc.ColumnName].ToString() + "',";
                            }
                            else
                            {
                                StrColumnsValues += dr[dc.ColumnName].ToString() + ",";
                            }
                        }

                    }
                }


                StrColumnsName = StrColumnsName.Substring(0, StrColumnsName.Length - 1);
                StrColumnsValues = StrColumnsValues.Substring(0, StrColumnsValues.Length - 1);


                Tawsol.InsertData("tblSessionHistory", StrColumnsName, StrColumnsValues);

                dbsession = Tawsol.RetreiveData_FromProcedure("sp_ListView_With_ClientId", "@SessionId", "int", SessionId, string.Empty);

                if (CheckDataSet(dbsession))
                {
                    DataRow DrChange = dbsession.Tables[0].Rows[0];

                    lstvClients.SelectedItems[0].BackColor = Color.White;
                    lstvClients.SelectedItems[0].SubItems[11].Text = ((int)TransferStatus.Accept).ToString();
                    lstvClients.SelectedItems[0].SubItems[5].Text = DrChange["Operator"].ToString();

                }


            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            mnuControl.Enabled = false;
            mnuView.Enabled = false;

            mnuLogin.Enabled = true;

 
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {

            frmLogin frmlgn = new frmLogin();
            frmlgn.ShowDialog();
        }
    }
}
