namespace HerramientasDeProgramacionII.Models
{
    public class FigurasModels
    {
        public decimal ladoX { get; set; }
        public decimal ladoY { get; set; }

        // Constructor sin parámetros
        public FigurasModels()
        {
        }

        // Constructor con parámetros
        public FigurasModels(decimal LadoX, decimal LadoY)
        {
            ladoX = LadoX;
            ladoY = LadoY;
        }

    }
}
