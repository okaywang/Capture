using PcapDotNet.Core;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capture
{
    public class PacketMonitor : IDisposable
    {
        private PacketDevice _device;
        private PacketCommunicator _communicator;

        public event Action<Packet> PacketRecieved;

        private Thread _threadCapture;
        public PacketMonitor(PacketDevice device, PacketCommunicatorMode mode)
        {
            _device = device;
            _communicator = _device.Open(65536, PacketDeviceOpenAttributes.NoCaptureRemote, 1000);
            _communicator.Mode = mode;
            _threadCapture = new Thread(ThreadCaptureHandler);
        }

        internal void SetFilter(string filterString)
        {
            var filter = _communicator.CreateFilter(filterString);
            _communicator.SetFilter(filter);
        }

        internal void Start()
        {
            if (_threadCapture.ThreadState == ThreadState.Suspended)
            {
                _threadCapture.Resume();
            }
            else
            {
                _threadCapture.Start();
            }

        }

        private void ThreadCaptureHandler()
        {
            _communicator.ReceivePackets(0, OnPacketRecieved);
        }

        internal void Stop()
        {
            _threadCapture.Suspend();
        }

        private void OnPacketRecieved(Packet packet)
        {
            if (PacketRecieved != null)
            {
                PacketRecieved(packet);
            }
        }

        public void Dispose()
        {
            _threadCapture.Abort();
            _communicator.Dispose();
        }
    }
}
