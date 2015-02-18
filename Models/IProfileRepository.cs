using System.Collections.Generic;

namespace Jander.HspService.Models
{

    public interface IProfileRepository {
        IEnumerable<Profile> AllProfiles { get; }
        void Add(Profile profile);
        Profile GetById(string id);
        bool TryDelete(string id);
    }
}
