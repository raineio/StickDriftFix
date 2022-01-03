using IPA;
using IPA.Config;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace StickDriftFix
{
    [Plugin(RuntimeOptions.DynamicInit), NoEnableDisable] 
    public class Plugin
    {
        private IPALogger _logger;

        [Init]
        public void Init(Zenjector zenjector, IPALogger logger, Config config)
        {
            _logger = logger;
            zenjector.UseLogger(logger);

            zenjector.Install<StickDriftFixCoreInstaller>(Location.App);
        }
    }
}