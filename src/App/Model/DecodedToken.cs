namespace AzureTokenMaker.App.Model {
    public sealed class DecodedToken {
        private readonly string _signature;
        private readonly string _claims;
        private readonly string _header;

        public DecodedToken(string signature, string claims, string header) {
            _signature = signature;
            _claims = claims;
            _header = header;
        }

        public string Signature {
            get { return _signature; }
        }

        public string Claims {
            get { return _claims; }
        }

        public string Header {
            get { return _header; }
        }
    }
}