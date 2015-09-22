
namespace AzureTokenMaker.App.Model {
    public sealed class TokenParameters {
        public string ClientId {
            get; set; }

        public string ClientKey {
            get; set; }

        public string ResourceId {
            get; set; }

        public string Username {
            get; set; }

        public string Password {
            get; set; }

        public string Tenant { get; set; }
    }
}