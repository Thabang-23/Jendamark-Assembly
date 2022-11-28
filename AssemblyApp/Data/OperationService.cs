using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssemblyApp.Models;

namespace AssemblyApp.Data
{
    public class OperationService
    {
        private readonly DeviceService _deviceService;

        public OperationService(DeviceService deviceService)
        {
            _deviceService = deviceService;
        }
        public List<Operation> OperationList { get; set; }
        public async Task<IEnumerable<Operation>> GetOperations()
        {
            var operations = new List<Operation> {
                new Operation { OperationID = 1, OrderInWhichToPerform = 1, Name = "Capture", DeviceID = 4 },
                new Operation { OperationID = 2, OrderInWhichToPerform = 2, Name = "Mill", DeviceID = 2 },
                new Operation { OperationID = 3, OrderInWhichToPerform = 3, Name = "Ground", DeviceID = 3 },
                new Operation { OperationID = 4, OrderInWhichToPerform = 4, Name = "Cut", DeviceID = 1 },
                new Operation { OperationID = 5, OrderInWhichToPerform = 1, Name = "Bolt", DeviceID = 2 },
            };
            OperationList = operations;
            return OperationList;

        }

        public async Task Create(Operation op)
        {
            var Operations = await GetOperations();
            Operation item = new Operation();
            if (op != null)
            {
                item.OperationID = Operations.Count() + 1;
                item.Name = op.Name;
                item.OrderInWhichToPerform = op.OrderInWhichToPerform;
                item.DeviceID = op.DeviceID;
                item.Device = await _deviceService.GetDeviceAsync(op.DeviceID);

                OperationList.Add(item);
            }
        }

        public void RemoveItem(int id)
        {
            var item = OperationList.Find(x => x.OperationID == id);
            OperationList.Remove(item);
        }       
    }
}