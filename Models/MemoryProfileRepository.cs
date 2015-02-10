using System;
using System.Collections.Generic;
using System.Linq;

namespace Jander.HspService.Models
{
    public class MemoryProfileRepository : IProfileRepository
    {
        readonly List<Profile> _profiles = new List<Profile> {
            new Profile { Id = 1, Email = "ella@jander.me" },
            new Profile { Id = 2, Email = "james@jander.me" }
        };

        public IEnumerable<Profile> AllProfiles
        {
            get
            {
                return _profiles;
            }
        }

        public Profile GetById(int id)
        {
            return _profiles.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Profile profile)
        {
            profile.Id = 1 + _profiles.Max(x => (int?)x.Id) ?? 0;
            _profiles.Add(profile);
        }

        public bool TryDelete(int id)
        {
            var profile = GetById(id);
            if (profile == null)
            {
                return false;
            }
            _profiles.Remove(profile);
            return true;
        }
    }
}
