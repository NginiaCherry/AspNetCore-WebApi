using System;
using Amazon.Lambda.Core;
using Amazon.Lambda.CodeDeployEvents;
using AspNetCore-WebApi;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AspNetCore-WebApi
{
    public class Function
    {
        public string FunctionHandler(CodeDeployEvent deploymentEvent, ILambdaContext context)
        {
            try
            {
                // Get the deployment ID from the CodeDeploy event
                string deploymentId = deploymentEvent.DeploymentId;

                // Perform deployment logic here, such as downloading the deployment package from S3 or running a deployment script
                // ...

                // Return a success message to CodeDeploy
                return "Deployment successful.";
            }
            catch (Exception ex)
            {
                // Return an error message to CodeDeploy
                return "Deployment failed: " + ex.Message;
            }
        }
    }
}
