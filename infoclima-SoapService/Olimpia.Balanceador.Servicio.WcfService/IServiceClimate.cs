using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using Olimpia.Balanceador.Servicio.InterRoot;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Transversal.Common;
using System.Threading.Tasks;
using System;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceClimate
    {

    #region Metodos Sincronos

    [OperationContract]
    Usuario Login(string username, string password);

    [OperationContract]
    Repuesta Registar(Clima clima);

    [OperationContract]
    Repuesta Actualizar(Clima clima);

    [OperationContract]
    Repuesta Eliminar(string climaId);

    [OperationContract]
    Clima Consultar(string climaId);

    [OperationContract]
    List<Clima> ConsultarTodos();

    #endregion 

    #region Metodos Asincronos
    /*
    [OperationContract]
    Task<Repuesta> RegistarAsync(Clima clima);

    [OperationContract]
    Task<Repuesta> ActualizarAsync(Clima clima);

    [OperationContract]
    Task<Repuesta> EliminarAsync(string climaId);

    [OperationContract]
    Task<Clima> ConsultarAsync(string climaId);

    [OperationContract]
    Task<List<Clima>> ConsultarTodosAsync();
    */
    #endregion

  }

  // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
  [DataContract]
  public class Clima
  {
    [DataMember]
    public int ClimaID { get; set; }
    [DataMember]
    public string Description { get; set; }
    [DataMember]
    public int Temperature { get; set; }
    [DataMember]
    public int Humidity { get; set; }
    [DataMember]
    public int Wind { get; set; }
    [DataMember]
    public string City { get; set; }
    [DataMember]
    public DateTime Date { get; set; }
  }

  [DataContract]
  public class Usuario
  {
    [DataMember]
    public int UserID { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public string UserName { get; set; }
    [DataMember]
    public string Password { get; set; }
    [DataMember]
    public string Token { get; set; }
  }

  [DataContract]
  public class Repuesta
  {
    [DataMember]
    public bool IsSuccess { get; set; }
    [DataMember]
    public string Messange { get; set; }
  }
}