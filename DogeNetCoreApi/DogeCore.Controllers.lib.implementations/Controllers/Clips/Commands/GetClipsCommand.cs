//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;
//using DogeNetCore.Controllers.lib.Controllers.Clips.Commands;
//using DogeNetCore.Controllers.lib.Controllers.Clips.Responses;
//using DogeNetCore.DataAccess.lib.ClipsRepository;
//using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;

//namespace DogeNetCore.Controllers.lib.implementations.Controllers.Clips.Commands
//{
//    public class GetClipsCommand : HttpGetCommand<Clip,GetClipsResponse>, IGetClipsCommand
//    {
//        private IClipRepository<Clip> _repository;
//        public GetClipsCommand(GetClipsResponse response, IClipRepository<Clip> repository) : base(response)
//        {
//            _repository = repository;
//        }

//        //public async Task<GetClipsResponse> GetClipsAsync()
//        //{
//        //    try
//        //    {

//        //    }
//        //    catch (Exception e)
//        //    {
//        //        Console.WriteLine(e);
//        //        throw;
//        //    }
//        //    var clips await _repository.GetAll();
//        //}

//        public async Task<GetClipsResponse> GetClipsAsync(string name)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<GetClipsResponse> GetClipsAsync(IEnumerable<string> name)
//        {
//            throw new NotImplementedException();
//        }

//        //public override GetClipsResponse MapResponse(Clip dataObject)
//        //{
//        //    throw new NotImplementedException();
//        //}

//        //public override GetClipsResponse MapResponse(IEnumerable<Clip> dataObjects)
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//}
