using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example10_Music_Player_System;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example10_Music_Player_System
{
    internal class BasicMusicPlayer: IMusicPlayer
    {
        public void Play() { /* Implementation */ }
        public void Pause() { /* Implementation */ }
        public void Stop() { /* Implementation */ }
        public void IncreaseVolume() { /* Implementation */ }
        public void DecreaseVolume() { /* Implementation */ }
        public void Mute() { /* Implementation */ }

        public void CreatePlaylist(string name)
        {
            throw new NotImplementedException();
        }

        public void AddToPlaylist(int songId, int playlistId)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromPlaylist(int songId, int playlistId)
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public void Repeat()
        {
            throw new NotImplementedException();
        }
    }
}
