using OWML.ModHelper;
using System;

namespace OWUkrainian
{
    internal interface ILocalizationAPI
    {
        void RegisterLanguage(ModBehaviour mod, string name, string translationPath);
    }
}
