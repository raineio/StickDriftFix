using StickDriftFix.AffinityPatches;
using StickDriftFix.Managers;
using Zenject;

namespace StickDriftFix
{
    public class StickDriftFixCoreInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<StickDriftFixManager>().AsSingle();
            Container.BindInterfacesAndSelfTo<XRNodePatch>().AsSingle();
        }
    }
}