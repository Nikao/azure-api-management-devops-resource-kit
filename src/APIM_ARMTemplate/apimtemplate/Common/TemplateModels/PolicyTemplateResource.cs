
using System;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common
{

    public class PolicyTemplateResource : APITemplateSubResource
    {
        public PolicyTemplateProperties properties { get; set; }
    }

    public class PolicyTemplateProperties
    {
        private string _policyContent;
        public string policyContent
        {
            get
            {
                const string fspEnvironmentPolicy = "<choose>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;beta&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://betaapi.flightschedulepro.com:8443/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;qa&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://qaapi.flightschedulepro.com:8445/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;integration&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://integrationtestapi.flightschedulepro.com/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;staging&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://stagingapi.flightschedulepro.com:8444/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<otherwise>\r\n\t\t\t\t<set-backend-service base-url=\"https://betaapi.flightschedulepro.com:8443/api/v10\" />\r\n\t\t\t</otherwise>\r\n\t\t</choose>";
                const string fspCurriculumEnvironmentPolicy = "<choose>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;beta&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://betafspcurriculumapi.azurewebsites.net/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;qa&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://qafspcurriculumapi.azurewebsites.net/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;integration&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://integrationtestfspcurriculumapi.azurewebsites.net/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<when condition=\"@(context.Request.Headers.GetValueOrDefault(&quot;x-fsp-environment&quot;) == &quot;staging&quot;)\">\r\n\t\t\t\t<set-backend-service base-url=\"https://stagingfspcurriculumapi.azurewebsites.net/api/v10\" />\r\n\t\t\t</when>\r\n\t\t\t<otherwise>\r\n\t\t\t\t<set-backend-service base-url=\"https://betafspcurriculumapi.azurewebsites.net/api/v10\" />\r\n\t\t\t</otherwise>\r\n\t\t</choose>";
                return _policyContent.Replace(fspEnvironmentPolicy, string.Empty, StringComparison.InvariantCultureIgnoreCase).Replace(fspCurriculumEnvironmentPolicy, string.Empty, StringComparison.InvariantCultureIgnoreCase);;
            }
            set => _policyContent = value;
        }

        public string contentFormat { get; set; }
    }
}
