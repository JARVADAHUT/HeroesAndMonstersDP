namespace DesignPatterns___DC_Design
{
    interface ICombatAction
    {
        void performAction(Target target);
        int getResourceUse();
    }
}
