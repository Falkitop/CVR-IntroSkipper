using MelonLoader;
using UnityEngine.SceneManagement;

namespace IntroSkipper
{

    ///If Many errors, VS is so stupid, refresh the outputpath
    public static class BuildInfo
    {
        public const string Name = "IntroSkipper";
        public const string Description = "IntroSkipper";
        public const string Author = "Falk";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class IntroSkipper : MelonMod
    {
        public override void OnSceneWasLoaded(int buildindex, string sceneName)
        {
            if (SceneManager.GetActiveScene().name == "Preparation")
                SceneManager.LoadSceneAsync(1);
        }
    }
}