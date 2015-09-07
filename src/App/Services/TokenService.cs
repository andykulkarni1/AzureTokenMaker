using System;
using System.Text;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AzureTokenMaker.App.Model;

namespace AzureTokenMaker.App.Services {
    public class TokenService {

        private readonly AuthenticationContext _context;

        public TokenService() {
            _context = new AuthenticationContext("https://login.windows.net/common");
        }
        public string GetClientToken ( TokenParameters parameters ) {
            if (parameters == null) {
                throw new ArgumentNullException("parameters");
            }

            var result = _context.AcquireToken( parameters.ResourceId,
                      new ClientCredential( parameters.ClientId, parameters.ClientKey ) );

            return result.AccessToken;
        }

        public string GetUserToken ( TokenParameters parameters ) {
            
            var result = _context.AcquireToken( parameters.ResourceId,
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
            JObject jsonPart = JObject.Parse( DecodeFromBase64( parts[0] ) );

            string header = jsonPart.ToString( Formatting.Indented );

            jsonPart = JObject.Parse( DecodeFromBase64( parts[1] ) );
            string claims = jsonPart.ToString( Formatting.Indented );

            string signature = parts[2];

            var result = new DecodedToken( signature, claims, header );

            return result;
        }

        //Note: Code was adapted from https://github.com/CommonWell/Token-Maker/blob/master/src/Token%20Maker/MainWindow.xaml.cs#L512
        //Thanks Peter Bernhardt!
        private static string DecodeFromBase64 ( string encodedData ) {
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
