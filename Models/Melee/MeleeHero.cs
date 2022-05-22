namespace gft_rpg_characters.Models.Melee
{
    public abstract class MeleeHero : Hero
    {
        public MeleeHero(string name, int level) : base(name, level){

        }

        public override void Attack()
        {
            int resource = 0;
            bool validString = false;
            do{
                Console.WriteLine();
                Console.WriteLine($"{_name} is preparing to attack!");
                Console.WriteLine("How many stamina points would you like to spend on this attack?");
                if (int.TryParse(Console.ReadLine(), out int num) && num <= _stamina){
                    validString = true;
                }else {
                    Console.WriteLine($"{_name} doesn't have that much stamina left! Please try again.");
                    validString = false;
            }
            resource = num;
            } while(!validString);
            
            int damage = 5 * resource;
            Console.WriteLine($"{_name} attacked with his {_weapon} using {resource} Stamina points.");
            _stamina = _stamina - resource;
            Console.WriteLine($"{_name} dealt {damage} points of damage!");
            Console.WriteLine($"{_name} now has {_stamina} stamina left.");
        }
    }
}