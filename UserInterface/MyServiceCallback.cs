using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.ServiceReference1;
using System.ServiceModel;

namespace UserInterface
{    
    class MyServiceCallback : IPocServerCallback
    {

        CallBackForm _form = null;

        public void setForm(CallBackForm form)
        {
            _form = form;
            _form.textBoxCallBack.Text = "TExte";
        }

        public MyServiceCallback(CallBackForm form)
        {
            _form = form;            
        }

        public MyServiceCallback()
        {
        }

        public void formMsg(Data msg)
        {
            if(_form != null) _form.setCallBackMsg(msg);
        }
        
        public void OnCallback(Data msg)
        {
            Console.WriteLine("> Received callback at {0}", DateTime.Now);
            Console.WriteLine("> Received callback message {0}", msg.TotalCount);
            formMsg(msg);            
        }
    }
}
