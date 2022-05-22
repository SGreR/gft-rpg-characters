namespace gft_rpg_characters.Models.Spellcasters
{
    public class WhiteWizard : Wizard
    {
        public WhiteWizard(string name, int level) : base(name, level){
            this._heroClass = "White Wizard";
        }
    }
}