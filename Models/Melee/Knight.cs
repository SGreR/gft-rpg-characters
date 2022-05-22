namespace gft_rpg_characters.Models.Melee
{
    public class Knight : MeleeHero
    {
        public Knight(string name, int level) : base(name, level){
            
            this._heroClass = "Knight";
            this._weapon = "Greatsword";
            this._maxHitPoints = 100;
            this._hitPoints = 100;
            this._maxMana = 25;
            this._mana = 25;
            this._maxStamina = 50;
            this._stamina = 50;
        }
    }
}