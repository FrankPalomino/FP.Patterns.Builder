namespace FP.Patterns.Builder.Exercice1
{
    internal class Director
    {
        public void MakeMage(ICharacterBuilder builder)
        {
            builder.SetName("Gandalf");
            builder.SetClass("Mage");
            builder.SetSkills("Fireball");
            builder.SetEquipment("Staff");
        }

        public void MakeWarrior(ICharacterBuilder builder)
        {
            builder.SetName("Conan");
            builder.SetClass("Warrior");
            builder.SetSkills("Sword");
            builder.SetEquipment("Sword");
        }
    }
}
