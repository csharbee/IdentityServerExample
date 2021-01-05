using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleIdentityServer.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>(){
                new ApiResource("resourceApi1"){Scopes={ "api1.read" , "api1.write" , "api1.update" } },
                new ApiResource("resourceApi2"){Scopes={ "api2.read" , "api2.write" , "api2.update" } }
            };
        }
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>() {
                new ApiScope("api1.read","Read Permission for API1"),
                new ApiScope("api1.write","Write Permission for API1"),
                new ApiScope("api1.update","Update Permission for API1"),
                new ApiScope("api2.read","Read Permission for API2"),
                new ApiScope("api2.write","Write Permission for API2"),
                new ApiScope("api2.update","Update Permission for API2"),
                new ApiScope()
            };
        }
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>() {
                new Client(){
                    ClientId="client1",
                    ClientName="Client 1",
                    ClientSecrets=new[] { new Secret("secret".Sha256()) },
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    AllowedScopes={ "api1.read", "api2.write" }
                },
                new Client(){
                    ClientId="client2",
                    ClientName="Client 2",
                    ClientSecrets=new[] { new Secret("secret".Sha256()) },
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    AllowedScopes={ "api1.read", "api2.write" }
                }
            };
        }
    }
}
