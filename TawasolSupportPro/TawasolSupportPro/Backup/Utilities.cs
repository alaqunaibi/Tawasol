using System;
using System.Xml;
using System.Windows.Forms;
using TawasolSupportPro;
using System.Threading;
using System.Xml.Serialization;
using System.Data;
using System.IO; 

namespace TawasolSupportPro
{
	/// <summary>
	/// Summary description for Utilities.
	/// </summary>
	public class Utilities
	{
		public Utilities( )
		{
   		}

        ///<summary>
        /// paramname = "ala"
        /// return string
        /// 
        /// </summary>
        /// 
        
        internal   void SerializeDataSet(DataSet Result)
        {
             XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            TextWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\SupportInfo.xml");
            ser.Serialize(writer, Result);
            writer.Close();
        }



        internal  void DeserializeDataSet(ref DataSet ResultInfo)
        {
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(DataSet));
            // If the XML document has been altered with unknown 
            // nodes or attributes, handles them with the 
            // UnknownNode and UnknownAttribute events.


            //			serializer.UnknownNode+= new  XmlNodeEventHandler(serializer_UnknownNode);
            //			serializer.UnknownAttribute+= new 
            //				XmlAttributeEventHandler(serializer_UnknownAttribute);
            //    
            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(Environment.CurrentDirectory + "\\SupportInfo.xml", FileMode.Open);
            // Declares an object variable of the type to be deserialized.

            // Uses the Deserialize method to restore the object's state with
            // data from the XML document. */
            ResultInfo = (DataSet)serializer.Deserialize(fs);
            fs.Close();

        }

        public void OpenLoginForm()
        {

            frmLogin lgn = new frmLogin();
            
            

            lgn.ShowDialog();
            if (lgn.DialogResult == DialogResult.OK)
           {
               lgn.Close();

                Thread abc = new Thread(new ThreadStart(OpenMainForm));
               
                abc.Start();
                    

            }
           
        }


        public void OpenMainForm()
        {

            Form1 frmMain = new Form1();


            frmMain.ShowDialog();
            
               
        }


        
	}
}
