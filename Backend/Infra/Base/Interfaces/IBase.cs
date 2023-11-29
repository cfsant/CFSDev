using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CFSDev.Backend.Infra.Interfaces.Base
{
    public interface IBase
    {
        [Key]
        Guid? Id { get; set; }
        Guid? OwnerId { get; set; }
        Guid? PublisherId { get; set; }
        DateTime? Insertion { get; set; }
        DateTime? Change { get; set; }

        [JsonIgnore]
        string? Hash { get; set; }
    }
}
