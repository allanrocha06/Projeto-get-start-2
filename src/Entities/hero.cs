namespace Projeto.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero(){} //Permite criar objeto "vazio", sem ser obrigatório passar os parâmetros.
            public string Name;
            public int Level;
            public string HeroType;
       
        public override string ToString() // override: sobrescrita de método
        { 
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack() // método "virtual": permite alterar código p/ copiar p/ Wizard.
        {
            return this.Name + " Atacou com sua espada";
        }
    }
}