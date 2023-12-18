namespace FP.Patterns.Builder.Exercice1
{
    internal class WarriorBuilder : ICharacterBuilder
    {
        private Warrior _warrior;

        public WarriorBuilder()
        {
            _warrior = new Warrior();
        }

        public void SetName(string name)
        {
            _warrior.Name = name;
        }

        public void SetClass(string clase)
        {
            _warrior.Class = clase;
        }

        public void SetSkills(string skills)
        {
            _warrior.Skills = skills;
        }

        public void SetEquipment(string equipment)
        {
            _warrior.Equipment = equipment;
        }

        public Warrior GetCharacter()
        {
            return _warrior;
        }
    }
}
