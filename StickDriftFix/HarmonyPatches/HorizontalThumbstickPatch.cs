using HarmonyLib;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(VRControllersInputManager), nameof(VRControllersInputManager.HorizontalAxisValue), MethodType.Normal)]
    public class HorizontalThumbstickPatch
    {
        public static bool Prefix(ref float __result)
        {
            __result = 0;
            return false;
        }
    }
}