#if !FAKE_XRM_EASY && !FAKE_XRM_EASY_2013
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using Xunit;

namespace FakeXrmEasy.Tests.FakeContextTests.RetrieveCurrentOrganizationRequestTests
{
    public class RetrieveCurrentOrganizationRequestTests
    {
        [Fact]
        public void When_retrieve_current_organization_is_called_without_context_default_organization_is_returned()
        {
            var context = new XrmFakedContext();
            var service = context.GetOrganizationService();

            var request = new RetrieveCurrentOrganizationRequest();

            var response = service.Execute(request) as RetrieveCurrentOrganizationResponse;

            Assert.Equal("FakeXrmEasy", response.Detail.UniqueName);
            Assert.Equal("9.0.0.0", response.Detail.OrganizationVersion);
        }

        [Fact]
        public void When_retrieve_current_organization_is_called_with_context_correct_organization_is_returned()
        {
            var context = new XrmFakedContext();
            var service = context.GetOrganizationService();

            var organization = new Entity("organization")
            {
                Id = Guid.NewGuid(),
                ["name"] = "AlbanianXrm",
                ["initialversion"] = "8.0.0.0"
            };
            context.Initialize(organization);

            var request = new RetrieveCurrentOrganizationRequest();

            var response = service.Execute(request) as RetrieveCurrentOrganizationResponse;

            Assert.Equal("AlbanianXrm", response.Detail.UniqueName);
            Assert.Equal("8.0.0.0", response.Detail.OrganizationVersion);
        }
    }
}
#endif