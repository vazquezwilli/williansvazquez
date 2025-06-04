namespace Manticora.Models
{
    public class JuegoModel
    {
        public List<Personaje> PersonajesDisponibles { get; set; }
        public Personaje Defensor1 { get; set; }

        public List<Arma> Armamentos { get; } = new List<Arma>
    {
        new Arma { Nombre = "Gran cañón", Precio = 80, Alcance = 50 },
        new Arma { Nombre = "Metralla", Precio = 60, Alcance = 40 },
        new Arma { Nombre = "Mosquete", Precio = 50, Alcance = 30 },
        new Arma { Nombre = "Pistola", Precio = 30, Alcance = 20 },
        new Arma { Nombre = "Granada", Precio = 10, Alcance = 10 }
    };
      
    }

    public class Personaje
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Oro { get; set; } = 100;
        public List<Arma> Inventario { get; set; } = new List<Arma>();
    }

    public class Arma
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Alcance { get; set; }
    }

    
}
