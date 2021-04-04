using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Bridge.II
{
    public class MessageAbstraction
    {
        protected IMessageImplementation MessageImplementation { get; }

        public MessageAbstraction(IMessageImplementation messageImplementation)
        {
            MessageImplementation = messageImplementation;
        }

        public  virtual void Send(string message)
        {
            MessageImplementation.SendMesssage(message);
        }
    }
}
