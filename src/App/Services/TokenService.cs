using System;
using System.Text;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AzureTokenMaker.App.Model;

namespace AzureTokenMaker.App.Services {
    public class TokenService {

        private AuthenticationContext _context;

        public string GetClientToken ( TokenParameters parameters ) {
            if (parameters == null) {
                throw new ArgumentNullException("parameters");
            }

            var context = getContext(parameters.Tenant);
            var result = context.AcquireToken(parameters.ResourceId,
                      new ClientCredential( parameters.ClientId, parameters.ClientKey ) );

            return result.AccessToken;
        }

        public string GetUserToken ( TokenParameters parameters ) {
            var context = getContext(parameters.Tenant);

            var result = context.AcquireToken(parameters.ResourceId,
                                  parameters.ClientId, new UserCredential( parameters.Username, parameters.Password ) );
            return result.AccessToken;
        }

        //Note: Code was adapted from https://github.com/CommonWell/Token-Maker/blob/master/src/Token%20Maker/MainWindow.xaml.cs#L213
        //Thanks Peter Bernhardt!
        public DecodedToken DecodeToken(string token) {
            if (String.IsNullOrWhiteSpace(token)) {
                throw new ArgumentException("token cannot be null or empty.", "token");
            }

            string[] parts = token.Split( '.' );
            JObject jsonPart = JObject.Parse( decodeFromBase64( parts[0] ) );

            string header = jsonPart.ToString( Formatting.Indented );

            jsonPart = JObject.Parse( decodeFromBase64( parts[1] ) );
            string claims = jsonPart.ToString( Formatting.Indented );

            string signature = parts[2];

            var result = new DecodedToken( signature, claims, header );

            return result;
        }

        private AuthenticationContext getContext(string tenant)
        {
            string authority = String.Format("https://login.windows.net/{0}", tenant);
            if (_context == null || !authority.Equals(_context.Authority, StringComparison.InvariantCultureIgnoreCase))
            {
                _context = new AuthenticationContext(authority);
            }
            return _context;
        }

        //Note: Code was adapted from https://github.com/CommonWell/Token-Maker/blob/master/src/Token%20Maker/MainWindow.xaml.cs#L512
        //Thanks Peter Bernhardt!
        private static string decodeFromBase64 ( string encodedData ) {
            int padding = encodedData.Length % 4;
            if ( padding > 0 ) {
                encodedData += new string( '=', ( 4 - padding ) );
            }
            byte[] encodedDataAsBytes = Convert.FromBase64String( encodedData );
            string returnValue = Encoding.ASCII.GetString( encodedDataAsBytes );

            return returnValue;
        }
    }

}
