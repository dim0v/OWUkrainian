using HarmonyLib;
using static TextTranslation;

namespace OWUkrainian
{
    [HarmonyPatch]
    public static class Patches
    {
        private static bool IsVanillaLanguage(Language lang) { return lang is >= Language.UNKNOWN and <= Language.TOTAL; }

        [HarmonyPrefix]
        [HarmonyPriority(Priority.Last)]
        [HarmonyPatch(typeof(TextTranslation), nameof(TextTranslation.IsLanguageLatin))]
        public static bool TextTranslation_IsLanguageLatin(TextTranslation __instance, ref bool __result)
        {
            if (IsVanillaLanguage(__instance.m_language)) return true;

            __result = false;
            return false;
        }
    }
}
