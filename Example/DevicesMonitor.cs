using ibox.sdk.external.controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Networking.Connectivity;

namespace Example
{
    public class DevicesMonitor
    {
        private static readonly IReadOnlyList<Windows.Networking.HostName> HOSTS 
            = NetworkInformation.GetHostNames();
        private static readonly Windows.Networking.HostName LOCAL_HOST 
            = HOSTS.FirstOrDefault(name => name.DisplayName.Contains(".local"));
        private static readonly string MACHINE_NAME 
            = LOCAL_HOST.DisplayName.Replace(".local", "");

        private const string DEVICE_USB = "USB#";
        private const string DEVICE_BT = "BTHE";

        private readonly Dispatcher Dispatcher;
        private DeviceWatcher deviceWatcher;

        public readonly ObservableCollection<Device> Devices = new ObservableCollection<Device>();

        public DevicesMonitor(Dispatcher dispatcher)
        {
            this.Dispatcher = dispatcher;
        }

        public void Start()
        {
            if (deviceWatcher == null)
            {
                deviceWatcher = DeviceInformation.CreateWatcher(SerialDevice.GetDeviceSelector());
                Devices.Clear();

                deviceWatcher.Added += OnDeviceAdded;
                deviceWatcher.Removed += OnDeviceRemoved;

                deviceWatcher.Start();
            }
        }

        public void Stop()
        {
            if (deviceWatcher != null)
            {
                deviceWatcher.Added -= OnDeviceAdded;
                deviceWatcher.Removed -= OnDeviceRemoved;

                deviceWatcher.Stop();
                deviceWatcher = null;
            }
        }

        private Device AddDevice(DeviceInformation deviceInfo)
        {
            Device device = null;
            var deviceType = deviceInfo.Id.Substring(4, 4);
            if (deviceType == DEVICE_BT)
            {
                device = new Device()
                {
                    ID = deviceInfo.Id,
                    ConnectionMode = ConnectionMode.BLUETOOTH,
                    Name = deviceInfo.Name
                };
            }
            else if (deviceType == DEVICE_USB)
            {
                var usbFilterStr = deviceInfo.Id.Substring(8, 23);
                if (usbFilterStr.Substring(usbFilterStr.Length - 2, 2) == "00" || deviceInfo.Id.Contains("VID_0E8D"))
                {
                    device = new Device()
                    {
                        ID = deviceInfo.Id,
                        ConnectionMode = ConnectionMode.USB,
                        Name = deviceInfo.Name
                    };                
                }
            }

            if (device != null)
                Devices.Add(device);

            return device;

        }

        private Device FindDevice(string deviceId) => Devices.FirstOrDefault(device => device.ID == deviceId);

        private async void OnDeviceAdded(DeviceWatcher sender, DeviceInformation deviceInfo)
        {
            await Dispatcher.InvokeAsync(new Action(() =>
                {
                    if (deviceInfo.Name != MACHINE_NAME)
                    {
                        AddDevice(deviceInfo);
                    }

            }));
        }

        private async void OnDeviceRemoved(DeviceWatcher sender, DeviceInformationUpdate deviceInfoUpdate)
        {
            await Dispatcher.InvokeAsync(new Action(() =>
            {
                var device = FindDevice(deviceInfoUpdate.Id);
                if (device != null)
                {
                    Devices.Remove(device);
                }

            }));
        }

        public class Device
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public ConnectionMode ConnectionMode { get; set; }

            public override string ToString()
            {
                return $"{(ConnectionMode == ConnectionMode.BLUETOOTH ? "BT" : "USB")} {Name}";
            }
        }
    }
}
