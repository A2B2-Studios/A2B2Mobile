using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Plugin.Maui.Audio;
using System.Threading.Tasks;

namespace A2Test2.Helpers
{
    public interface IAudioPlayerService
    {
        Task AddPlayer(string name, double balance, double volume);
        Task PlayUISound(string name);
        Task<bool> PlayerExists(string name);
        Task<IAudioPlayer> GetPlayer(string name);
        Task RemovePlayer(string name);
        Task ShouldPlayInterop(MouseEventArgs e, IJSRuntime? jsInstance);
    }
}
