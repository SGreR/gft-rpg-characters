using gft_rpg_characters.Models.Melee;
using gft_rpg_characters.Models.Spellcasters;

namespace gft_rpg_characters.Models
{
    static class Menu
    {
        private static string ChooseClass(){
            Console.Clear();
            Console.WriteLine("Please select your hero's class:");
            Console.WriteLine("1 - Knight");
            Console.WriteLine("2 - Ninja");
            Console.WriteLine("3 - White Wizard");
            Console.WriteLine("4 - Black Wizard");

            switch(Console.ReadLine()){
                case "1":
                    return "1";
                case "2":
                    return "2";
                case "3":
                    return "3";
                case "4":
                    return "4";
                default:
                    return "";
            }
        }

        private static string ChooseName(){
            string heroName = "";
            Console.WriteLine("Choose the name of your hero: ");
            heroName = Console.ReadLine();
            return heroName;
        }

        private static int SetLevel(){
            int level = 0;
            bool validString;
            do{
                Console.Clear();
                Console.WriteLine("Please select your hero's starting level (1 to 20): ");
                if(int.TryParse(Console.ReadLine(), out int num) && (num > 0) && (num <= 20)){
                    validString = true;
                } else {
                    validString = false;
                }
                level = num;
            }while (!validString);
            return level;
        }

        public static Hero CreateHero(){
            var heroName = ChooseName();
            string heroType = "";
            while(String.IsNullOrEmpty(heroType))
            {
                heroType = ChooseClass();
            }
            var level = SetLevel();

            Hero hero = null;
            switch (heroType){
                case "1":
                    hero = new Knight(heroName, level);
                    return hero;
                case "2":
                    hero = new Ninja(heroName, level);
                    return hero;
                case "3":
                    hero = new WhiteWizard(heroName, level);
                    return hero;
                case "4":
                    hero = new BlackWizard(heroName, level);
                    return hero;
                default:
                    return hero;
            }
        }

        public static void PrintHeroInfo(Hero hero){
            Console.WriteLine("Hero's name: " + hero._name);
            Console.WriteLine("Hero's level and class: Level "+ hero._level + " " + hero._heroClass);
            Console.WriteLine("Hero's weapon: " + hero._weapon);
            Console.WriteLine("Hero's maximum hit points: " + hero._maxHitPoints);
            Console.WriteLine("Hero's maximum mana points: " + hero._maxMana);
            Console.WriteLine("Hero's max stamina: " + hero._maxStamina);
        }
    }
}