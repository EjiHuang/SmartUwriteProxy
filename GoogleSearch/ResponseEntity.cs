using Newtonsoft.Json;

namespace GoogleSearchApplication
{
    class ResponseEntity<T>
    {
        [JsonProperty("code")]
        string code;
        [JsonProperty("msg")]
        string msg;
        [JsonProperty("response")]
        T response;
        public T GetResponse()
        {
            return response;
        }
    }
}
