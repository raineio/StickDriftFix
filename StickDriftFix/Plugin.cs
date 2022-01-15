using System;
using System.Reflection;
using HarmonyLib;
using IPA;
using IPALogger = IPA.Logging.Logger;

namespace StickDriftFix
{
    [Plugin(RuntimeOptions.DynamicInit)] 
    public class Plugin
    {
        private const string HarmonyID = "com.raineio.stickdriftfix";
        private static readonly Harmony Harmony = new Harmony(HarmonyID);

        public static IPALogger Logger;
        
        [Init]
        public void Init()
        { }

        [OnEnable]
        internal void OnEnable()
        {
            ApplyHarmonyPatches();
        }

        [OnDisable]
        internal void OnDisable()
        {
            RemoveHarmonyPatches();
        }

        private static void ApplyHarmonyPatches()
        {
            try
            {
                Logger?.Debug("Applying Harmony Patches..");
                Harmony.PatchAll(Assembly.GetExecutingAssembly());
            }
            catch (Exception e)
            {
                Logger?.Error("Failed to apply patches: " + e.Message);
                Logger?.Debug(e);
            }
        }

        private static void RemoveHarmonyPatches()
        {
            try
            {
                Harmony.UnpatchSelf();
            }
            catch(Exception e)
            {
                Logger?.Error("Failed to remove patches: " + e.Message);
                Logger?.Debug(e);
            }
        }
    }
}