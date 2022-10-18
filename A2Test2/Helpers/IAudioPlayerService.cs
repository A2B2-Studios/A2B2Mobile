using System.Threading.Tasks;

namespace A2Test2.Helpers
{
    public interface IAudioPlayerService
    {
        Task AddUISound(string name, double balance, double volume);
        Task PlayUISound(string name);
    }
}
