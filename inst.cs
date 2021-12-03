using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using GOTEVOT.Training.Institutes.Web.Template.Interface;

    /// <summary>
    /// Summary description for inst
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class inst : System.Web.Services.WebService
    {

        public inst()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public string SaveSelectedItemsInSession(string SelectedItems)
        {
            string x = "Hello Alaa";
            x = SelectedItems;
            return x;
        }
        [WebMethod(EnableSession=true)]
        public void KillSession()
        {
            System.Web.SessionState.HttpSessionState IISSession = System.Web.HttpContext.Current.Session;
            IISSession.RemoveAll();
            IISSession.Clear();
            IISSession.Abandon();
        }

    }

