namespace DesignPattern.Builder
{
    public class GameRole
    {
        public string Name { get; private set; }
        public string PictureUrl { get; private set; }
        public int Lv { get; private set; }
        public string AttackSkill { get; private set; }
        public string DefenseSkill { get; private set; }
        public string MagicSkill { get; private set; }

        private GameRole()
        {
        }

        public static IBuilder GetBuilder(string type)
        {
            if (type == "A")
            {
                return new Builder();
            }
            return new Builder();
        }

        public interface IBuilder
        {
            public IBuilder AddBase(string name, string pictureUrl);
            public IBuilder AddLv(int lv);
            public IBuilder AddAttackSkill(string attackSkill);
            public IBuilder AddDefenseSkill(string defenseSkill);
            public IBuilder AddMagicSkill(string magicSkill);

            public GameRole CreateRole();
        }

        public class Builder : IBuilder
        {
            private GameRole _role;

            public Builder()
            {
                _role = new GameRole();
            }

            public IBuilder AddBase(string name, string pictureUrl)
            {
                _role.Name = name;
                _role.PictureUrl = pictureUrl;
                _role.Lv = 1;
                return this;
            }

            public IBuilder AddAttackSkill(string attackSkill)
            {
                _role.AttackSkill = attackSkill;
                return this;
            }

            public IBuilder AddDefenseSkill(string defenseSkill)
            {
                _role.DefenseSkill = defenseSkill;
                return this;
            }

            public IBuilder AddLv(int lv)
            {
                _role.Lv = lv;
                return this;
            }

            public IBuilder AddMagicSkill(string magicSkill)
            {
                _role.MagicSkill = magicSkill;
                return this;
            }

            public GameRole CreateRole()
            {
                return _role;
            }
        }
    }
}
