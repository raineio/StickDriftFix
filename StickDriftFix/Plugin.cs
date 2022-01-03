using IPA;
using IPA.Config;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace StickDriftFix
{
    [Plugin(RuntimeOptions.DynamicInit),
     NoEnableDisable] // NoEnableDisable supresses the warnings of not having a OnEnable/OnStart
    // and OnDisable/OnExit methods
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        internal static IPALogger Log { get; private set; }

        [Init]
        public void Init(Zenjector zenjector, IPALogger logger, Config config)
        {
            Instance = this;
            Log = logger;
            zenjector.UseLogger(logger);

            zenjector.Install<StickDriftFixCoreInstaller>(Location.App);
        }
    }
}