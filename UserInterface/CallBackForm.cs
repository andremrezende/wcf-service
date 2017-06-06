using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ServiceReference1;
using System.ServiceModel;



namespace UserInterface
{
    public partial class CallBackForm : Form
    {
        public CallBackForm()
        {
            InitializeComponent();
        }        

        private void CallBackForm_Load(object sender, EventArgs e)
        {           

            
        }

        public void setCallBackMsg(Data data)
        {
            textBoxCallBack.Text = "Total Count : " + data.TotalCount;
            textBoxCallBack.AppendText("\r\n" + "Software : " + data.SoftwareVersion);
            textBoxCallBack.AppendText("\r\n" + "ComTick : " + data.ComTick);
            textBoxCallBack.AppendText("\r\n" + "IsInit : " + data.IsInit);
            textBoxCallBack.AppendText("\r\n" + "-----NameList-----");
            foreach (var item in data.NameList)
            {
                textBoxCallBack.AppendText("\r\n" + "Name : " + item);
                textBoxCallBack.AppendText("\r\n" + "-------------------------");
            }
            textBoxCallBack.AppendText("\r\n" + "-----Composite-----");
            foreach (var item in data.CompositeData)
            {
                textBoxCallBack.AppendText("\r\n" + "Id : " + item.Id);
                textBoxCallBack.AppendText("\r\n" + "Length : " + item.Length);
                textBoxCallBack.AppendText("\r\n" + "Area : " + item.Area);
                textBoxCallBack.AppendText("\r\n" + "Width : " + item.Width);
                textBoxCallBack.AppendText("\r\n" + "Status : " + item.Status);
                textBoxCallBack.AppendText("\r\n" + "ProcTime : " + item.ProcTime);
                textBoxCallBack.AppendText("\r\n" + "-------------------------");
            }
                        
        }
    }
}
