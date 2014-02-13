using System;
using System.Collections.Generic;

namespace DesignPatterns___DC_Design
{
    class Target : IEnumerable<DungeonCharacter>
    {
        private List<DungeonCharacter> targets;

        public void AddTarget(DungeonCharacter target)
        {
            this.targets.Add(target);
        }

        public void RemoveTarget(DungeonCharacter target)
        {
            this.targets.Remove(target);
        }

        public IEnumerator<DungeonCharacter> GetEnumerator()
        {
            return this.targets.GetEnumerator();
        }

        //I'm not sure what this method stub is.
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
