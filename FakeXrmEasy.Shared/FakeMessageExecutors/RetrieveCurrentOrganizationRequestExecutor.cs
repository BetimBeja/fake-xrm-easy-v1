#if FAKE_XRM_EASY_2015 || FAKE_XRM_EASY_2016 || FAKE_XRM_EASY_365 || FAKE_XRM_EASY_9
using Microsoft.Xrm.Sdk;
using System;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Organization;
using System.Linq;

namespace FakeXrmEasy.FakeMessageExecutors
{
    public class RetrieveCurrentOrganizationRequestExecutor : IFakeMessageExecutor
    {
        public bool CanExecute(OrganizationRequest request)
        {
            return request is RetrieveCurrentOrganizationRequest;
        }

        public OrganizationResponse Execute(OrganizationRequest request, XrmFakedContext ctx)
        {
            var req = (RetrieveCurrentOrganizationRequest)request;
            OrganizationDetail organizationDetail = new OrganizationDetail();

            Entity entity;
            if (ctx.Data.ContainsKey("organization") &&
               ctx.Data["organization"].Count > 0)
            {
                entity = ctx.CreateQuery("organization").First();
            }
            else
            {
                entity = new Entity("organization")
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001")
                };
            }

            organizationDetail.OrganizationId = entity.Id;
            organizationDetail.UrlName = "https://fakexrmeasy.crm.dynamics.com";
            organizationDetail.UniqueName = entity.GetAttributeValue<string>("name") ?? "FakeXrmEasy";
            organizationDetail.OrganizationVersion = entity.GetAttributeValue<string>("initialversion") ?? "9.0.0.0";
            organizationDetail.State = entity.GetAttributeValue<OrganizationState>("organizationstate");

            return new RetrieveCurrentOrganizationResponse
            {
                Results = new ParameterCollection
                {
                    { "Detail", organizationDetail }
                }
            };
        }

        public Type GetResponsibleRequestType()
        {
            return typeof(RetrieveCurrentOrganizationRequest);
        }
    }
}
#endif