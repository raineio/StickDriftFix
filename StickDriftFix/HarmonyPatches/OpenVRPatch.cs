using HarmonyLib;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(OpenVRHelper), "add_joystickWasNotCenteredThisFrameEvent")]
    public static class OpenVRPatch
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            return false;
        }
    }
}