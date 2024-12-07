namespace HerramientasDeProgramacionII.Models
{
    public class ResultadoFiguraModels : FigurasModels
    {
        public decimal area { get; set; }
        public decimal perimetro { get; set; }

        // Constructor sin parámetros
        public ResultadoFiguraModels()
        {
        }

        // Constructor con parámetros
        public ResultadoFiguraModels(decimal LadoX, decimal LadoY)
        {
            ladoX = LadoX;
            ladoY = LadoY;
        }
    }
}
