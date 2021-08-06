using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.API.Config
{
    public static class ConfigIS4
    {
        public static IEnumerable<IdentityResource> GetIdResources()
        => new IdentityResource[]{ new IdentityResources.OpenId(),
              new IdentityResources.Profile()};
        //co nhieu service thi co nhieu apis
        public static IEnumerable<ApiResource> GetApis()
        => new ApiResource[] { new ApiResource("exam_api", "Exam API") };

        public static IEnumerable<ApiScope> GetScopes()
        => new ApiScope[] { new ApiScope("full_access", "Full quyen hanh") };

        public static IEnumerable<Client> GetClients(Dictionary<string,string> clientUrls)
        => new Client[]{
            new Client
            {
                ClientId="exam_web_app",
                ClientName="exam_web_app",
                ClientSecrets = { new Secret("secret_con_cac".Sha256()) },
                ClientUri = clientUrls["ExamWebApp"] ,
                AllowedCorsOrigins = { clientUrls["ExamWebApp"]},
                AllowedGrantTypes= GrantTypes.Code ,
                AllowAccessTokensViaBrowser = true ,
                RequireConsent = false,
                AllowOfflineAccess = true,
                AlwaysIncludeUserClaimsInIdToken = true ,
                RedirectUris = new string[]
                {
                    $@"{clientUrls["ExamWebApp"]}/authentication/login-callback"
                },
                PostLogoutRedirectUris = new string[]
                {
                    $@"{clientUrls["ExamWebApp"]}/authentication/logout-callback"
                },
                AllowedScopes = new[]
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.OfflineAccess,
                    "full_access"
                },
                AccessTokenLifetime = 3600, // 1 tieng
                IdentityTokenLifetime = 3600,
                RequireClientSecret = true,   //
                RequirePkce = true
            },
             new Client
            {
                ClientId="exam_web_admin",
                ClientName="exam_web_admin",
                ClientSecrets = { new Secret("secret_con_cac".Sha256()) },
                ClientUri = clientUrls["ExamWebAdmin"] ,
                AllowedCorsOrigins = { clientUrls["ExamWebAdmin"] },
                AllowedGrantTypes= GrantTypes.Code ,
                AllowAccessTokensViaBrowser = true ,
                RequireConsent = false,
                AllowOfflineAccess = true,
                AlwaysIncludeUserClaimsInIdToken = true ,
                RedirectUris = new string[]
                {
                    $@"{clientUrls["ExamWebAdmin"]}/authentication/login-callback"
                },
                PostLogoutRedirectUris = new string[]
                {
                    $@"{clientUrls["ExamWebAdmin"]}/authentication/logout-callback"
                },
                AllowedScopes = new[]
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.OfflineAccess,
                    "full_access"
                },
                AccessTokenLifetime = 3600, // 1 tieng
                IdentityTokenLifetime = 3600,
                RequireClientSecret = true,   //
                RequirePkce = true
            },
            new Client
            {
                ClientId="exam_swagger",
                ClientName="exam_swagger",
                AllowedGrantTypes= GrantTypes.Implicit ,
                AllowAccessTokensViaBrowser = true ,
                RedirectUris = new string[]
                {
                    $@"{clientUrls["ExamWebApp"]}/swagger/oauth2-redirect.html"
                },
                PostLogoutRedirectUris = new string[]
                {
                    $@"{clientUrls["ExamWebApp"]}/swagger"
                },
                AllowedScopes = new[]
                {
                    "exam_api"
                }
            }
        };
    }
}
