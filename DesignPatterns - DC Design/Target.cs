using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns___DC_Design
{
    class Target : IEnumerable<DungeonCharacter>
    {
        private List<DungeonCharacter> targets;

        public void addTarget(DungeonCharacter target)
        {
            this.targets.Add(target);
        }

        public void removeTarget(DungeonCharacter target)
        {
            this.targets.Remove(target);
        }

        public IEnumerator<DungeonCharacter> GetEnumerator()
        {
            return this.targets.GetEnumerator();
        }

        //I'm not sure what this method stud is.
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
