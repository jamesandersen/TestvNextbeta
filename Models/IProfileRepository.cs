using System.Collections.Generic;

namespace Jander.HspService.Models
{

    public interface IProfileRepository {
        IEnumerable<Profile> AllProfiles { get; }
        void Add(Profile profile);
        Profile GetById(int id);
        bool TryDelete(int id);
    }
}
