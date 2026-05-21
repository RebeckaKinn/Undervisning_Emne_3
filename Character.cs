namespace Undervisning_Emne_3
{
    internal class Character
    {
        private string _type;
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _strength;

        public Character(string type, string name, int health, int maxHealth, int strenth)
        {
            _type = type;
            _name = name;
            _health = health;
            _maxHealth = maxHealth;
            _strength = strenth;
        }

        public Character()
        {
            _type = "Goblin";
            _name = "Unknown";
            _health = _maxHealth = 10;
            //_maxHealth = 10;
            _strength = 1;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Type: {_type}\n" +
                $"Name: {_name}\n" +
                $"Health: {_health}\n" +
                $"Max health: {_maxHealth}\n" +
                $"Strength: {_strength}\n");

        }
        public int GetStrength()
        {
            return _strength;
        }
        public void TakeDamage(Character doesDamage)
        {
            _health -= doesDamage._strength;
        }
    }
}
