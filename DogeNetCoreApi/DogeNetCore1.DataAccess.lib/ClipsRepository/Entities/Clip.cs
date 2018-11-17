using System;
using System.ComponentModel.DataAnnotations;
using DogeNetCore.DataAccess.lib.Entities;

namespace DogeNetCore.DataAccess.lib.ClipsRepository.Entities
{
    public class Clip : IEntity<string>
    {
        /// <summary>
        /// Unique identifier for the clip, used for relation
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Unique name called to invoke the clip
        /// </summary>
        [Required,MaxLength(24)]
        public string Name { get; set; }
        /// <summary>
        /// The location of the clip resource
        /// </summary>
        [Required]
        public string Uri { get; set; }
        /// <summary>
        /// The source type for the clip, such as youtube
        /// </summary>
        [Required]
        public ClipSourceType SourceType { get; set; }

        /// <summary>
        /// Optional start time in seconds for the clip, defaults to start
        /// </summary>      
        public int StartTime { get; set; } = 0;
        /// <summary>
        /// Optional end time in seconds for the clip, defaults to end of clip
        /// </summary>
        public int EndTime { get; set; }
        /// <summary>
        /// Optional description of the clip
        /// </summary>
        public string Description { get; set; }


        public string Key => Name;
    }
}
