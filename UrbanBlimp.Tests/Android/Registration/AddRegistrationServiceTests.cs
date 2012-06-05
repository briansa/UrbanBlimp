using System.Collections.Generic;
using NUnit.Framework;
using UrbanBlimp.Android;

namespace UrbanBlimp.Tests.Android
{
    [TestFixture]
    public class AddRegistrationServiceTests
    {


        [Test]
        [Ignore]
        public void Tags()
        {
            var service = new AddRegistrationService
                              {
                                  RequestBuilder = RequestBuilderHelper.Build()
                              };
            var registration = new NewRegistration
                                   {
                                       Tags = new List<string> {"bangladesh"}
                                   };

            var helper = new AsyncTestHelper();
            service.Execute(RemoteSettings.AndroidPushId, registration, helper.Callback, helper.HandleException);
            helper.Wait();
        }
    }
}