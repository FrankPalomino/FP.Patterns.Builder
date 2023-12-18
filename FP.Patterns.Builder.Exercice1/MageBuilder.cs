namespace FP.Patterns.Builder.Exercice1
{
    internal class MageBuilder : ICharacterBuilder
    {
        private Mage _mage;

        public MageBuilder()
        {
            _mage = new Mage();
        }

        public void SetName(string name)
        {
            _mage.Name = name;
        }

        public void SetClass(string clase)
        {
            _mage.Class = clase;
        }

        public void SetSkills(string skills)
        {
            _mage.Skills = skills;
        }

        public void SetEquipment(string equipment)
        {
            _mage.Equipment = equipment;
        }

        public Mage GetCharacter()
        {
            return _mage;
        }
    }
}
