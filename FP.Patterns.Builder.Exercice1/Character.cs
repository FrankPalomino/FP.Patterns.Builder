namespace FP.Patterns.Builder.Exercice1
{
    internal abstract class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Skills { get; set; }
        public string Equipment { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nClass: {Class}\nSkills: {Skills}\nEquipment: {Equipment}";
        }
    }
}
