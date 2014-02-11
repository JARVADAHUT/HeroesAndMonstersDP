namespace DesignPatterns___DC_Design
{
    interface ICombatAction
    {
        public abstract void performAction(Target target);
        public abstract int getResourceUse();
    }
}
