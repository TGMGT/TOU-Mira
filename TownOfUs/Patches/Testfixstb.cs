using System;
using HarmonyLib;

namespace TeytofixSetrunfs
{
    public static class CrashDuzPatch
    {
        [HarmonyPatch(typeof(PassiveButton), nameof(PassiveButton.ReceiveClickDown))]
        [HarmonyPrefix]
        public static bool PrefixClickDown(PassiveButton __instance)
        {
            if (__instance == null || __instance.Pointer == IntPtr.Zero)
            {
                return false;
            }
            return true;
        }
      
        [HarmonyPatch(typeof(PassiveButton), nameof(PassiveButton.ReceiveClickUp))]
        [HarmonyPrefix]
        public static bool PrefixClickUp(PassiveButton __instance)
        {
            if (__instance == null || __instance.Pointer == IntPtr.Zero)
            {
                return false;
            }
            return true;
        }
    }
}
