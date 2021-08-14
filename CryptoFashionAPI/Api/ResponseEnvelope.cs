namespace CryptoFashionAPI.Api
{
    public class ResponseEnvelope<T>
    {
        public T Data { get; set; }

        public ResponseEnvelope()
        {
        }

        public ResponseEnvelope(T response)
        {
            Data = response;
        }
    }
}