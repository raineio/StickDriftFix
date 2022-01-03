using System;
using SiraUtil.Logging;
using Zenject;
using UnityEngine.XR;

namespace StickDriftFix.Managers
{
    internal class StickDriftFixManager : IInitializable, IDisposable
    {
        private SiraLog _siraLog;
        
        public StickDriftFixManager(SiraLog siraLog)
        {
            _siraLog = siraLog;
        }
        
        public void Initialize()
        {
            _siraLog.Info($"Initialized {nameof(StickDriftFixManager)}");
        }

        public void FixStickDrift()
        {
        }

        public void Dispose()
        {
        }
    }
}