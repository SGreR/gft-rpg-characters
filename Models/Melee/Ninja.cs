namespace gft_rpg_characters.Models.Melee
{
    public class Ninja : MeleeHero
    {
        public Ninja(string name, int level) : base(name, level){
            
            this._heroClass = "Ninja";
            this._weapon = "Katana";
            this._maxHitPoints = 75;
            this._hitPoints = 75;
            this._maxMana = 40;
            this._mana = 40;
            this._maxStamina = 30;
            this._stamina = 30;
        }
        
    }
}