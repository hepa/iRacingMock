﻿using iRacingSdkWrapper;
using iRacingSdkWrapper.Broadcast;
using iRSDKSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static iRacingSdkWrapper.SdkWrapper;

namespace iRacingMock.ClassLibrary
{
    public class Mock : ISdkWrapper
    {
        private string[] _file;

        private string[] _headers;
        private Dictionary<int, Dictionary<string, string>> _telemetryInfos;

        public Mock(string[] file)
        {
            _file = file;
            _telemetryInfos = new Dictionary<int, Dictionary<string, string>>();
            this.context = SynchronizationContext.Current;
            this.EventRaiseType = EventRaiseTypes.CurrentThread;
        }

        public Mock()
        {
            _telemetryInfos = new Dictionary<int, Dictionary<string, string>>();
            this.context = SynchronizationContext.Current;
            this.EventRaiseType = EventRaiseTypes.CurrentThread;
        }

        private readonly SynchronizationContext context;
        

        public iRacingSDK Sdk => throw new NotImplementedException();

        public EventRaiseTypes EventRaiseType { get; set; }

        public bool IsRunning => throw new NotImplementedException();

        public bool IsConnected => throw new NotImplementedException();

        public double TelemetryUpdateFrequency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ConnectSleepTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int DriverId => throw new NotImplementedException();

        public ReplayControl Replay => throw new NotImplementedException();

        public CameraControl Camera => throw new NotImplementedException();

        public PitCommandControl PitCommands => throw new NotImplementedException();

        public ChatControl Chat => throw new NotImplementedException();

        public TextureControl Textures => throw new NotImplementedException();

        public TelemetryRecordingControl TelemetryRecording => throw new NotImplementedException();

        public event EventHandler<SdkWrapper.TelemetryUpdatedEventArgs> TelemetryUpdated;
        public event EventHandler<SdkWrapper.SessionInfoUpdatedEventArgs> SessionInfoUpdated;
        public event EventHandler Connected;
        public event EventHandler Disconnected;

        public object GetData(string headerName)
        {
            return DateTime.Now;
        }

        public ITelemetryValue<T> GetTelemetryValue<T>(string name)
        {
            throw new NotImplementedException();
        }

        public void RequestSessionInfoUpdate()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            StartRandom();
            //ReadHeaders();

            //for (int i = 1; i < _file.Length; i++)
            //{
            //    var telemetryInfo = new Dictionary<string, string>();
            //    var telemetryInfos = SplitLine(_file[i]);
            //    for (int j = 0; j < telemetryInfos.Length; j++)
            //    {
            //        telemetryInfo.Add(_headers[j], telemetryInfos[j]);
            //    }
            //    _telemetryInfos.Add(i, telemetryInfo);
            //}

            //WriteOut();
        }

        public void StartRandom()
        {
            Thread.Sleep(500);
            OnConnected(EventArgs.Empty);

            while (true)
            {
                OnTelemetryUpdated(new TelemetryUpdatedEventArgs(new MockTelemetryInfo() { Speed = new MockTelemetryValue<float>() { Value = 100 } }, DateTime.Now.Ticks));
                Thread.Sleep(33);
            }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        private void ReadHeaders()
        {
            _headers = SplitLine(_file[0]);
        }

        private string[] SplitLine(string s)
        {
            return s.Split(',');
        }

        private void WriteOut()
        {
            for (int i = 1; i <= _telemetryInfos.Count; i++)
            {
                
                Thread.Sleep(100);
            }
        }

        private void RaiseEvent<T>(Action<T> del, T e)
            where T : EventArgs
        {
            var callback = new SendOrPostCallback(obj => del(obj as T));

            if (context != null && this.EventRaiseType == EventRaiseTypes.CurrentThread)
            {
                // Post the event method on the thread context, this raises the event on the thread on which the SdkWrapper object was created
                context.Post(callback, e);
            }
            else
            {
                // Simply invoke the method, this raises the event on the background thread that the SdkWrapper created
                // Care must be taken by the user to avoid cross-thread operations
                callback.Invoke(e);
            }
        }

        private void OnTelemetryUpdated(TelemetryUpdatedEventArgs e)
        {
            var handler = this.TelemetryUpdated;
            if (handler != null) handler(this, e);
        }

        private void OnConnected(EventArgs e)
        {
            var handler = this.Connected;
            if (handler != null) handler(this, e);
        }
    }
}
