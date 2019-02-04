using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    /// <summary>
    /// All the object that will communicate eith each other
    /// </summary>
    interface Sendable
    {
        /// <summary>
        /// Gets the data of the object to send
        /// </summary>
        /// <returns></returns>
        byte[] GetData();

        /// <summary>
        /// Updates the data to send
        /// </summary>
        void UpdateData();
    }
}