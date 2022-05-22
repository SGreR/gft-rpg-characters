namespace gft_rpg_characters.Models.Spellcasters
{
    public class BlackWizard : Wizard
    {
        public BlackWizard(string name, int level) : base(name, level){
            this._heroClass = "Black Wizard";
        }
    }
}