using HarmonyLib;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(VRControllersInputManager), nameof(VRControllersInputManager.VerticalAxisValue), MethodType.Normal)]
    public class VerticalThumbstickPatch
    {
        public static bool Prefix(ref float __result)
        {
            __result = 0;
            return false;
        }
    }
}