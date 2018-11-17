using System;
using DogeNetCore.Controllers.lib.Controllers.Clips.Commands;
using DogeNetCore.Controllers.lib.Controllers.Clips.Requests;
using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;
using DogeNetCore.DataAccess.lib.ClipsRepository;
using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogeNetCore.DataAccess.lib.UserRepository.Entities;

namespace DogeNetCore.Controllers.lib.implementations.Controllers.Clips.Commands
{
    public class ClipsCommand : IClipsCommand
    {
        private readonly IClipRepository<Clip> _repository;

        public ClipsCommand(IClipRepository<Clip> repository)
        {
            _repository = repository;
        }

        public async Task<GetClipsResponse> GetClips()
        {
            throw new NotImplementedException();
            //var clips = await _repository.GetAll();
            //var result = new GetClipsResponse
            //{
            //    Clips = new List<Clip>();
            //};
            //foreach (var clip in clips)
            //{
                
            //}
        }

        public async Task<GetClipsResponse> GetUsers(IEnumerable<string> usernames)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetLeaderBoard()
        {
            throw new NotImplementedException();
        }

        public async Task<GetClipsResponse> GetClip(string name)
        {
            throw new NotImplementedException();
        }

        public async Task AddClip(AddClipRequest clip)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveUser(string username)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUsername(string currentUsername, string newUsername)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddScoreToUser(string username, int toAdd)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUserScore(string username, int newScore)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
