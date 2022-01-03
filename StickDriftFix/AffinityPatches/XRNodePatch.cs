using SiraUtil.Affinity;

namespace StickDriftFix.AffinityPatches
{
    public class XRNodePatch : IAffinity
    {
        [AffinityPrefix]
        static bool Prefix()
        {
            return false;
        }
    }
}