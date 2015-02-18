using System;
using System.Collections.Generic;
using System.Linq;

namespace Jander.HspService.Models
{
    public class MemoryProfileRepository : IProfileRepository
    {
        readonly List<Profile> _profiles = new List<Profile> {
            new Profile { Id = Guid.NewGuid().ToString(), Email = "ella@jander.me" , Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit." },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me", Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla placerat semper vestibulum. Quisque imperdiet sem lorem, in tempor ante mattis nec. Phasellus lacinia neque vel finibus luctus. Nam vulputate odio sed euismod egestas. Fusce auctor lacus in diam efficitur, eget ultricies mauris euismod. In at mattis diam, sed rhoncus nisl. Sed pretium efficitur congue. Morbi blandit feugiat placerat. Fusce eget egestas magna, sed rutrum metus. Sed dictum sollicitudin venenatis. Praesent ante velit, accumsan sit amet lobortis cursus, pellentesque et erat. Aliquam eu suscipit elit."  },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me" },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me" },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me" },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me" },
            new Profile { Id = Guid.NewGuid().ToString(), Email = "james@jander.me" },
        };

        public IEnumerable<Profile> AllProfiles
        {
            get
            {
                return _profiles;
            }
        }

        public Profile GetById(string id)
        {
            return _profiles.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Profile profile)
        {
            profile.Id = Guid.NewGuid().ToString();
            _profiles.Add(profile);
        }

        public bool TryDelete(string id)
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
