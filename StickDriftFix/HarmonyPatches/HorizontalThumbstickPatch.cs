using HarmonyLib;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(VRControllersInputManager), nameof(VRControllersInputManager.HorizontalAxisValue), MethodType.Getter)]
    public static class HorizontalThumbstickPatch
    {
        [HarmonyPrefix]
        public static bool Prefix(ref float __result)
        {
            __result = 0;
            return false;
        }
    }
}