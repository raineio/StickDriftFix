using HarmonyLib;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(VRControllersInputManager), nameof(VRControllersInputManager.HorizontalAxisValue), MethodType.Normal)]
    public static class HorizontalThumbstickPatch
    {
        [HarmonyPrefix]
        public static bool Patch(ref float __result)
        {
            __result = 0;
            return false;
        }
    }
}