namespace PeliculasAPI.Servicios
{
    public interface IAlmacenadorArchivos
    {
        //Contenedor: Carpeta donde se guardan archivos relacionados
        Task<string> GuardarArchivo(byte[] contenido, string extension, string contenedor, string contenType);

        Task<string> EditarArchivo(byte[] contenido, string extension, string contenedor, string ruta, string contenedorType);

        Task BorrarArchivo(string ruta, string contenedor);
    }
}
