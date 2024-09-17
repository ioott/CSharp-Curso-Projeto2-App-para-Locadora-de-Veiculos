namespace RentCars.Types

{
    public struct Color
    {
        // Nome da cor
        public string Name { get; set; }

        // Código hexadecimal da cor
        public string Hex { get; set; }

        // Construtor opcional para facilitar a inicialização
        public Color(string name, string hex)
        {
            Name = name;
            Hex = hex;
        }
    }
}
