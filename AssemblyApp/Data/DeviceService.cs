using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssemblyApp.Models;

namespace AssemblyApp.Data
{
    public class DeviceService
    {
        public IEnumerable<Device> GetDevices()
        {
            var devices = new List<Device> 
            {
                new Device { DeviceID = 1, Name = "Insertion Machine", DeviceType = DeviceType.SocketTray },
                new Device { DeviceID = 2, Name = "Laser Marking Machine", DeviceType = DeviceType.Printer },
                new Device { DeviceID = 3, Name = "Clinching Machine", DeviceType = DeviceType.SocketTray },
                new Device { DeviceID = 4, Name = "Assembly Unit", DeviceType = DeviceType.BarcodeScanner }
            };

            return devices;
        }

        public async Task<Device> GetDeviceAsync(int id)
        {
            var devices = GetDevices();

            return devices.FirstOrDefault(x => x.DeviceID == id);
        }
    }
}