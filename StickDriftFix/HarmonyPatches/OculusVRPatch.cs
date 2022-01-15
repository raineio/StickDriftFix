using HarmonyLib;

namespace StickDriftFix.HarmonyPatches
{
    [HarmonyPatch(typeof(OculusVRHelper), "add_joystickWasNotCenteredThisFrameEvent")]
    public class OculusVRPatch
    {
        [HarmonyPrefix]
        public static bool Prefix()
        {
            return false;
        }
    }
}