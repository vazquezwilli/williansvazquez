namespace Manticora.Models
{
    // Models/Character.cs
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Gold { get; set; } = 100;
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
    }

    // Models/Weapon.cs
    public class Weapon
    {
        public string Name { get; set; }
        public int Range { get; set; }
        public int Cost { get; set; }
    }

    // Models/Game.cs
    public class Game
    {
        public Character[] Defenders { get; set; } = new Character[2];
        public int ManticoreHealth { get; set; } = 10;
        public int CityHealth { get; set; } = 15;
        public int ManticorePosition { get; set; }
        public int Turn { get; set; } = 1;
    }

}
