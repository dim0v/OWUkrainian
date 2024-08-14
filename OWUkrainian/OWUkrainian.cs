using System.Reflection;
using HarmonyLib;
using OWML.Common;
using OWML.ModHelper;

namespace OWUkrainian
{
    public class OWUkrainian : ModBehaviour
    {
        private const string LangName = "UKRAINIAN";

        public void Start()
        {
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
            ModHelper.Console.WriteLine($"{nameof(OWUkrainian)} is loaded!", MessageType.Success);

            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, LangName, "assets/Translation.xml");
        }
    }
}
