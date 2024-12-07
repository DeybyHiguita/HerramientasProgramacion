using HerramientasDeProgramacionII.Models;

namespace HerramientasDeProgramacionII.Bussiness
{
    public class HerenciaPOOBusiness
    {
        public ResultadoFiguraModels CalcularCirculo(FigurasModels figurasModels)
        {
            CirculoBussiness circulo = new CirculoBussiness(figurasModels);
            ResultadoFiguraModels resultadoFiguraModels = new ResultadoFiguraModels(figurasModels.ladoX, figurasModels.ladoY);
            resultadoFiguraModels.area = circulo.CalcularArea();
            resultadoFiguraModels.perimetro = circulo.CalcularPerimetro();
            return resultadoFiguraModels;
        }

        public ResultadoFiguraModels CalcularRectangulo(FigurasModels figurasModels)
        {
            RectanguloBusinness rectangulo = new RectanguloBusinness(figurasModels);
            ResultadoFiguraModels resultadoFiguraModels = new ResultadoFiguraModels(figurasModels.ladoX, figurasModels.ladoY);
            resultadoFiguraModels.area = rectangulo.CalcularArea();
            resultadoFiguraModels.perimetro = rectangulo.CalcularPerimetro();
            return resultadoFiguraModels;
        }

        public ResultadoFiguraModels CalcularTriangulo(FigurasModels figurasModels)
        {
            TrianguloBusinness triangulo = new TrianguloBusinness(figurasModels);
            ResultadoFiguraModels resultadoFiguraModels = new ResultadoFiguraModels(figurasModels.ladoX, figurasModels.ladoY);
            resultadoFiguraModels.area = triangulo.CalcularArea();
            resultadoFiguraModels.perimetro = triangulo.CalcularPerimetro();
            return resultadoFiguraModels;
        }
    }
}
