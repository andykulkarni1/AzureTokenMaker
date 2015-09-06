using System.Collections;
using System.Collections.Generic;

namespace AzureTokenMaker.App {
    sealed class ProfileCollection : IEnumerable<Profile> {

        private HashSet<Profile> _profiles = new HashSet<Profile>();

        public void Add ( Profile target ) {
            _profiles = new HashSet<Profile>( _profiles ) { target };
        }
        public IEnumerator<Profile> GetEnumerator () {
            return _profiles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator () {
            return GetEnumerator();
        }
    }
}