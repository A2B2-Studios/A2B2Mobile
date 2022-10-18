using Microsoft.JSInterop;
using Plugin.Maui.Audio;
using System.Threading.Tasks;

namespace A2Test2.Helpers
{
    public class AudioPlayerService : IAudioPlayerService
    {
        private readonly IAudioManager audioManager;
        private readonly Dictionary<string, IAudioPlayer> audioPlayers = new Dictionary<string, IAudioPlayer>();

        public AudioPlayerService(IAudioManager audioManager)
        {
            this.audioManager = audioManager;
        }

        public async Task AddUISound(string name, double balance, double volume)
        {
            var sfxPlayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(name));

            sfxPlayer.Balance = balance;
            sfxPlayer.Volume = volume;

            audioPlayers.Add(name, sfxPlayer);
        }

        public async Task PlayUISound(string name)
        {
            var sfxPlayer = audioPlayers[name];
            sfxPlayer.Play();
        }
    }
}
