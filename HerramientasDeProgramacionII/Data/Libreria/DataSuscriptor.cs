using HerramientasDeProgramacionII.Models.Libreria;

namespace HerramientasDeProgramacionII.Data.Libreria
{
    public class DataSuscriptor : SQLProviderBase
    {
        private string querySelectAll = "SELECT * FROM libreria.suscriptores";
        private string querySelectByKey = "SELECT * FROM libreria.suscriptores WHERE documento = @documento";

        // Método para obtener todos los suscriptores
        public List<SuscriptorModel> ObtenerTodos()
        {
            List<SuscriptorModel> suscriptores = new List<SuscriptorModel>();
            try
            {
                List<object[]> result = ExecuteReader(querySelectAll);
                foreach (var row in result)
                {
                    suscriptores.Add(new SuscriptorModel
                    {
                        Documento = (string)row[0],
                        Nombre = (string)row[1],
                        Direccion = (string)row[2]
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return suscriptores;
        }

        // Método para obtener un suscriptor por documento (clave primaria)
        public SuscriptorModel ObtenerPorDocumento(string documento)
        {
            SuscriptorModel suscriptor = null;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@documento", documento }
                };

                List<object[]> result = ExecuteReader(querySelectByKey, parameters);
                if (result.Count > 0)
                {
                    var row = result[0];
                    suscriptor = new SuscriptorModel
                    {
                        Documento = (string)row[0],
                        Nombre = (string)row[1],
                        Direccion = (string)row[2]
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return suscriptor;
        }
    }
}
