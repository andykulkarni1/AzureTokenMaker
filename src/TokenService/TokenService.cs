using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace AzureTokenMaker.Service {
    public class TokenService {

        private readonly AuthenticationContext _context;

        public TokenService() {
            _context = new AuthenticationContext("https://login.windows.net/common");
        }
        public async Task<string> GetClientToken ( TokenParameters parameters ) {
            if (parameters == null) {
                throw new ArgumentNullException("parameters");
            }

            var result = await _context.AcquireTokenAsync( parameters.ResourceId,
                      new ClientCredential( parameters.ClientId, parameters.ClientKey ) );

            return result.AccessToken;
        }

        public string GetUserToken ( TokenParameters parameters ) {
            
            var result = _context.AcquireToken( parameters.ResourceId,
                                  parameters.ClientId, new UserCredential( parameters.Username, parameters.Password ) );
            return result.AccessToken;
        }
    }
}
