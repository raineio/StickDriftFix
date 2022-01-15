using HarmonyLib;
using IPALogger = IPA.Logging.Logger;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(VRControllersInputManager), nameof(VRControllersInputManager.VerticalAxisValue), MethodType.Normal)]
    public static class VerticalThumbstickPatch
    {

        [HarmonyPrefix]
        public static bool Prefix(ref float __result)
        {
            __result = 0;
            return false;
        }
    }
}