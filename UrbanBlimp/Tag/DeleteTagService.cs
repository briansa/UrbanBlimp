using System;

namespace UrbanBlimp.Tag
{
    public class DeleteTagService
    {
        public IRequestBuilder RequestBuilder;
        public void Execute(string tag, Action<bool> callback, Action<Exception> exceptionCallback)
        {
            var request = RequestBuilder.Build("https://go.urbanairship.com/api/tags/" + tag);
            request.Method = "DELETE";
            request.DoRequest(callback, exceptionCallback);
        }

    }
}