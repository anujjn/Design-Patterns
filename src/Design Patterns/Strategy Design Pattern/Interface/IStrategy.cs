using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Interface
{
    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
