using DogeNetCore.DataAccess.lib.ClipsRepository.Entities;
using System;
using System.Collections.Generic;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework.ClipRepository.Entities
{
    //For testing and debugging
    public static class ClipContextExtensions
    {
        public static void EnsureSeedDataForContext(this ClipContext context)
        {
            context.Clips.RemoveRange(context.Clips);
            context.SaveChanges();

            var clips = new List<Clip>()
            {
                new Clip
                {
                    Id = new Guid("b77dfb03-ac54-4832-859c-95624a9c6ae8"),
                    Name = "Wow",
                    Uri = "https://www.youtube.com/watch?v=cE8hO79bsOc",
                    SourceType = ClipSourceType.RawUri,
                    Description = "Single Owen Wilson Wow"
                },
                new Clip
                {
                    Id = new Guid("01625b08-1238-4a58-bfc5-283b1dbd70eb"),
                    Name = "Horn",
                    Uri = "https://www.youtube.com/watch?v=ah4VQXe8YqU",
                    SourceType = ClipSourceType.RawUri,
                    Description = "Single rap air horn",
                }
            };

            context.Clips.AddRange(clips);
            context.SaveChanges();
        }
    }
}
