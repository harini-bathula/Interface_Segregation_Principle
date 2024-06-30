using Interface_Segregation_Principle.Good_Examples.Interfaces.Example10_Music_Player_System;
namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example10_Music_Player_System
{
    public class AdvancedMusicPlayer : IPlayable, IPlaylistManagement, IVolumeControl
    {
        public void Play() { /* Implementation */ }
        public void Pause() { /* Implementation */ }
        public void Stop() { /* Implementation */ }
        public void CreatePlaylist(string name) { /* Implementation */ }
        public void AddToPlaylist(int songId, int playlistId) { /* Implementation */ }
        public void RemoveFromPlaylist(int songId, int playlistId) { /* Implementation */ }
        public void IncreaseVolume() { /* Implementation */ }
        public void DecreaseVolume() { /* Implementation */ }
        public void Mute() { /* Implementation */ }
    }
}
