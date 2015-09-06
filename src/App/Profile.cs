using System;
using AzureTokenMaker.Service;

namespace AzureTokenMaker.App {

    public enum ProfileType {
        Client,
        User
    }

    sealed class Profile {

        public string Name { get; set; }

        public TokenParameters Data {
            get; set; }

        public ProfileType Type {
            get; set; }

        public override int GetHashCode () {
            return Name.GetHashCode();
        }
    }
}