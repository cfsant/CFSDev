using CFSDev.Backend.Infra.Base.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CFSDev.Backend.Infra.Implementations.Base
{
    public class Base : IBase
    {
        private string? _hash { get; set; }
        [Key]
        public Guid? Id { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? PublisherId { get; set; }
        public DateTime? Insertion { get; set; }
        public DateTime? Change { get; set; }

        [JsonIgnore]
        public string? Hash {
            get
            {
                if (string.IsNullOrEmpty(_hash) || string.IsNullOrWhiteSpace(_hash))
                    _hash = HashGen();

                var iVal = HashGen();
                if (iVal != _hash)
                    _hash = HashGen();

                return _hash;
            }
            set
            {
                _hash = value;
            }
        }

        protected virtual string? HashGen()
        {
            return CFSDev.Libs.Cryptography.Functions.SHA512(JsonConvert.SerializeObject(this));
        }
    }
}
