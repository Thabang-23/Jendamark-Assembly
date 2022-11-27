using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssemblyApp.Models;

namespace AssemblyApp.Data
{
    public class OperationService
    {
        public async Task<List<Operation>> GetOperations()
        {
            var operations = new List<Operation> {
                new Operation { OperationID = 1, OrderInWhichToPerform = 1, Name = "Capture" },
                new Operation { OperationID = 2, OrderInWhichToPerform = 2, Name = "Mill" },
                new Operation { OperationID = 3, OrderInWhichToPerform = 3, Name = "Ground" },
                new Operation { OperationID = 4, OrderInWhichToPerform = 4, Name = "Cut" },
                new Operation { OperationID = 5, OrderInWhichToPerform = 1, Name = "Bolt" },
            };

            return operations;;
        }       
    }
}