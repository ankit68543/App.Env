using System;
using System.Collections.Concurrent;

namespace App.Env.Provider
{
    public sealed class RolesProvider
    {
        private static readonly Lazy<RolesProvider> lazy
            = new(() => new RolesProvider());

        public static RolesProvider Instance
            => lazy.Value;

        private RolesProvider() { }

        public ConcurrentDictionary<string, int> rolesCollection = new();
    }

}
