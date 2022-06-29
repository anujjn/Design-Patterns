using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Design_Pattern.Interface
{
    interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
