using FacebookApi.Interfaces.IApiEngine;

namespace FacebookApi.ApiEngine
{
    public class BatchRequestBodyParameter : IBatchRequestBodyParameter
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
