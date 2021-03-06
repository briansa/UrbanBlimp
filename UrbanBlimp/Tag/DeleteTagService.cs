using System;

namespace UrbanBlimp.Tag
{
    public class DeleteTagService
    {
        public IRequestBuilder RequestBuilder;
        public void Execute(DeleteTagRequest request, Action<DeleteTagResponse> responseCallback, Action<Exception> exceptionCallback)
        {
            var webRequest = RequestBuilder.Build("https://go.urbanairship.com/api/tags/" + request.Tag);
			webRequest.Method = "DELETE";
			webRequest.ContentType = "application/json";

            var asyncRequest = new AsyncRequest
            {
                Request = webRequest,
                ReadFromResponse = o => responseCallback(new DeleteTagResponse()),
                ExceptionCallback = exceptionCallback,
            };
            asyncRequest.Execute(); 
        }

    }
}