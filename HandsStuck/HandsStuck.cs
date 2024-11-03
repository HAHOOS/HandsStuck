using MelonLoader;
using System.Linq;
using UnityEngine.XR.OpenXR;

namespace HandsStuck
{
    public class HandsStuck : MelonMod
    {
        public const string Version = "1.0.0";

        public override void OnInitializeMelon()
        {
            var eyegaze = OpenXRSettings.Instance.features.First(x => x.name.StartsWith("EyeGazeInteraction"));
            if (eyegaze?.enabled == true)
            {
                eyegaze.enabled = false;
                OpenXRSettings.Instance.ApplySettings();
                LoggerInstance.Msg("Disabled EyeGazeInteraction feature, which breaks controller tracking on SteamVR beta");
            }
            else
            {
                LoggerInstance.Msg("It seems like the feature is not enabled, which means the bug was already fixed by the devs");
            }
        }
    }
}