namespace danj_backend.Helper
{
    public class CustomResponse
    {
        public object objResponse { get; set; }
        public string message { get; set; }

        public CustomResponse(string objResponse, string message){
            this.objResponse = objResponse;
            this.message = message;
        }
    }
}
