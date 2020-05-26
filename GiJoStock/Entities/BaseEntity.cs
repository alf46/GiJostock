using Newtonsoft.Json;

namespace GiJoStock
{
    public class BaseEntity
    {
        public bool Enable { get; set; } = true;

        [JsonIgnore]
        public string EnableDesc
        {
            get
            {
                return this.Enable ? "Activado" : "Inactivado";
            }
        }
    }
}