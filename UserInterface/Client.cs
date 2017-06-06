using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ServiceReference1;
using System.ServiceModel;


namespace UserInterface
{
    public partial class Client : Form
    {

        public ObservableCollection<PartData> CompositeData { get; set; } 

        public Client()
        {
            InitializeComponent();
            CompositeData = new ObservableCollection<PartData>();

            CallBackForm callBackF = new CallBackForm();
            callBackF.Show();

            MyServiceCallback callback = new MyServiceCallback(callBackF);
            InstanceContext instanceContext = new InstanceContext(callback);
            PocServerClient service = new PocServerClient(instanceContext);
            service.subscribe();           
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            openFileDialogPic.Title = "Open a Text File";
            openFileDialogPic.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*"; //Here you can filter which all files you wanted allow to open  
            DialogResult dr = openFileDialogPic.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialogPic.FileName);
                // txtEx.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            DialogName dName = new DialogName();
            DialogResult dr = dName.ShowDialog();
            if (dr == DialogResult.OK)
            {
                listBoxName.BeginUpdate();
                listBoxName.Items.Add(dName.textBoxName.Text);
                listBoxName.EndUpdate();
            }            
        }

        private void buttonComposite_Click(object sender, EventArgs e)
        {
            DialogComposite dComposite = new DialogComposite();
            DialogResult dr = dComposite.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PartData partData = new PartData();
                int x = 0;
                if (Int32.TryParse(dComposite.textBoxId.Text, out x))
                {
                    partData.Id = x;
                }

                int y = 0;
                if (Int32.TryParse(dComposite.textBoxArea.Text, out y))
                {
                    partData.Area = y;
                }

                int z = 0;
                if (Int32.TryParse(dComposite.textBoxLegth.Text, out z))
                {
                    partData.Length = z;
                }

                int a = 0;
                if (Int32.TryParse(dComposite.textBoxWidth.Text, out a))
                {
                    partData.Width = a;
                }
                partData.Status = dComposite.checkBoxStatus.Checked;
                CompositeData.Add(partData);


                listBoxComposite.BeginUpdate();
                listBoxComposite.Items.Clear();

                foreach (var item in CompositeData)
                {
                    listBoxComposite.Items.Add(item.Id);
                }
                listBoxComposite.EndUpdate();

            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            int x = 0;
            if (Int32.TryParse(textBoxTotal.Text, out x))
            {
                data.TotalCount = x;
            }

            data.SoftwareVersion = textBoxSoftware.Text;

            long l1 = (long)Convert.ToDouble(textBoxCom.Text);
            data.ComTick = l1;
            data.IsInit = checkBoxIsInit.Checked;
            
            PartData[] compositeArray = new PartData[CompositeData.Count];
            int i2 = 0;
            foreach (var item in CompositeData)
            {
                compositeArray[i2] = ((PartData) item);
                i2++;
            }
            data.CompositeData = compositeArray;

            string[] NameList = new string[listBoxName.Items.Count] ;
            int i = 0;
            foreach (var item in listBoxName.Items)
            {
                NameList[i] = ((string) item);
                i++;
            }
            data.NameList = NameList;

            ReceiverClient receiverService = new ReceiverClient();
            receiverService.send(data);
        } 
    }
}
