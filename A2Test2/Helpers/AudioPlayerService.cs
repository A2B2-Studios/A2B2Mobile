using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Plugin.Maui.Audio;
using System.Threading.Tasks;

namespace A2Test2.Helpers
{
    public class AudioPlayerService : IAudioPlayerService
    {
        private readonly IAudioManager audioManager;
        private readonly Dictionary<string, IAudioPlayer> audioPlayers = new Dictionary<string, IAudioPlayer>();

        public AudioPlayerService(IAudioManager audiomanager)
        {
            this.audioManager = audiomanager;
        }

        public async Task AddPlayer(string name, double balance, double volume)
        {
            var sfxPlayer = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(name));

            sfxPlayer.Balance = balance;
            sfxPlayer.Volume = volume;

            audioPlayers.Add(name, sfxPlayer);
        }

        public async Task<bool> PlayerExists(string name)
        {
            if (!audioPlayers.ContainsKey(name))
            {
                return false;
            }

            return true;
        }

        public async Task<IAudioPlayer> GetPlayer(string name)
        {
            return audioPlayers[name];
        }

        public async Task RemovePlayer(string name)
        {
            audioPlayers[name].Dispose();
            audioPlayers.Remove(name);
        }

        public async Task ShouldPlayInterop(MouseEventArgs e, IJSRuntime? jsInstance)
        {
            if (jsInstance != null)
            {
                string sfxToPlay = await jsInstance.InvokeAsync<string>("ShouldPlaySfx", e.ClientX, e.ClientY);

                if (sfxToPlay != "false")
                {
                    await PlayUISound(sfxToPlay);
                }
            }
        }

        public async Task PlayUISound(string name)
        {
            var sfxPlayer = audioPlayers[name];
            sfxPlayer.Play();
        }

    }
}
