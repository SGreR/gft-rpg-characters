namespace gft_rpg_characters.Models
{
    public abstract class Hero
    {
        public string _name {get; protected set;}
        public int _level {get; protected set;}
        public string _heroClass {get; protected set;}
        public string _weapon {get; protected set;}
        public int _maxHitPoints {get; protected set;}
        public int _hitPoints {get; protected set;}
        public int _maxMana {get; protected set;}
        public int _mana {get; protected set;}
        public int _maxStamina {get; protected set;}
        public int _stamina {get; protected set;}

        public Hero(string name, int level){
            _name = name;
            _level = level;
        }
        public virtual void Attack(){

        }

        public void Rest(){
            Console.WriteLine();
            Console.WriteLine($"{_name} is taking a rest.");
            Console.WriteLine($"{_name} is now fully rested.");
            _hitPoints = _maxHitPoints;
            _mana = _maxMana;
            _stamina = _maxStamina;
            Console.WriteLine($"{_name}'s hit points are now back to {_hitPoints}");
            Console.WriteLine($"{_name}'s mana points are now back to {_mana}");
            Console.WriteLine($"{_name}'s stamina points are now back to {_stamina}");
        }
}
}