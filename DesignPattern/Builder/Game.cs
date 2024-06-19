namespace DesignPattern.Builder
{
    public class Game
    {
        public Game()
        {
        }

        public GameRole CreatenNewbie()
        {
            return GameRole.GetBuilder("A").AddBase("村民", "https://base.img")
                .CreateRole();
        }

        public GameRole CreatenMagicSwordsman()
        {
            return GameRole.GetBuilder("A").AddBase("魔劍士", "https://magicSwordsman.img")
                .AddAttackSkill("斬擊")
                .AddDefenseSkill("閃躲")
                .AddMagicSkill("火球術")
                .AddLv(100)
                .CreateRole();
        }
    }
}
