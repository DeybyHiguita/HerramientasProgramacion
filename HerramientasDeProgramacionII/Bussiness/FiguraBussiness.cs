using HerramientasDeProgramacionII.Models;

namespace HerramientasDeProgramacionII.Bussiness
{
    abstract class FiguraBussiness
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }

    internal class CirculoBussiness : FiguraBussiness
    {
        public FigurasModels figurasModels { get; set; }

        public CirculoBussiness(FigurasModels models)
        {
            figurasModels = models;
        }

        public override decimal CalcularArea()
        {
            double Area =  Math.PI * Math.Pow(Convert.ToDouble(figurasModels.ladoY), 2);
            return Convert.ToDecimal(Area);
        }

        public override decimal CalcularPerimetro()
        {
            double perimetro = 2 * Math.PI * Convert.ToDouble(figurasModels.ladoY);
            return Convert.ToDecimal(perimetro);
        }
    }

    internal class RectanguloBusinness : FiguraBussiness
    {
        public FigurasModels figurasModels { get; set; }

        public RectanguloBusinness(FigurasModels models)
        {
            figurasModels = models;
        }

        public override decimal CalcularArea()
        {
            return figurasModels.ladoX * figurasModels.ladoY;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (figurasModels.ladoX + figurasModels.ladoY);
        }
    }

    internal class TrianguloBusinness : FiguraBussiness
    {
        public FigurasModels figurasModels { get; set; }

        public TrianguloBusinness(FigurasModels models)
        {
            figurasModels = models;
        }

        public override decimal CalcularArea()
        {
            return (figurasModels.ladoX * figurasModels.ladoY) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            double hipotenusa = Math.Sqrt(Math.Pow((double)figurasModels.ladoX, 2) + Math.Pow((double)figurasModels.ladoY, 2));
            return Convert.ToDecimal(figurasModels.ladoX + figurasModels.ladoY + (decimal)hipotenusa);
        }

    }
}
