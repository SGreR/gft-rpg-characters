namespace gft_rpg_characters.Models.Spellcasters
{
    public abstract class Wizard : Hero
    {
        public Wizard(string name, int level) : base(name, level){
            this._weapon = "Spells";
            this._maxHitPoints = 30;
            this._hitPoints = 30;
            this._maxMana = 100;
            this._mana = 100;
            this._maxStamina = 25;
            this._stamina = 25;
        }

        public override void Attack()
        {
            int resource = 0;
            bool validString = false;
            do{
                Console.WriteLine();
                Console.WriteLine($"{_name} is preparing to attack!");
                Console.WriteLine("How many mana points would you like to spend on this attack?");
                if (int.TryParse(Console.ReadLine(), out int num) && num <= _mana){
                    validString = true;
                } else {
                    Console.WriteLine($"{_name} doesn't have that much mana left! Please try again.");
                    validString = false;
            }
            resource = num;
            } while(!validString);

            int damage = 5 * resource;
            Console.WriteLine($"{_name} cast a spell using {resource} Mana points.");
            _mana = _mana - resource;
            Console.WriteLine($"{_name} dealt {damage} points of damage!");
            Console.WriteLine($"{_name} now has {_mana} mana left.");
        }
    }
}