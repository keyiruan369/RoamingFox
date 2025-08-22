using System;
using Amazon;

public class ExternalParameters
{   
    // Facebook Variables are required only if you are using Facebook
    public static string FacebookAppId = ""; // eg. 987654321012345
    public static string FacebookClientToken = ""; // eg. 1234567890abcdefg0987654321
    
    // AWS variables
    public static RegionEndpoint region = RegionEndpoint.USEast2; // change this if you are in a different region
    public static Uri ApiGatewayEndpoint = new Uri("https://k8j32dlkjf.execute-api.us-east-2.amazonaws.com/v1/"); // eg. https://123abcxyz.execute-api.us-east-2.amazonaws.com (do not put PATH)

    // Amazon Cognito Variables
    public static string identityPool = "us-east-2:e7566616-eec4-44ec-81e1-c1f909b7918e"; // eg. us-east-2:000000-aaaa-bbbb-cccc-12345667890
    public static string userPoolId = "us-east-2_CiwKK7ysk"; // eg. us-east-2_abcd1234
    public static string appClientId = "2gt5fk07u7eslo6dujqvmia7ps"; // eg. 1a2b3c4d5e6g7h8i9j

    // Amazon S3 variables
    public static string S3BucketName = "aws-cognito-unity-integra-roamingfoxbucket83104fa4-tkwc2exjhew1"; // eg. ...unitycognitobucket...
    public static string S3ObjectKeyPrefix = "cognito/aws-cognito-unity-integration/"; // eg. 'cognito/aws-cognito-unity-integration/' Update here requires update to IAM role

    // Amazon DynamoDB variables
    public static string DynamoDBTableName = "AWS-Cognito-Unity-Integration-RoamingFoxDB4085F9B3-UBLKQ7WZA5HJ"; // eg. ...UnityCognitoDB....
}
