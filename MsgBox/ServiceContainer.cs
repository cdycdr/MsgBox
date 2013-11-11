namespace MsgBox
{
  using System;
  using System.Collections.Generic;

  /// <summary>
  /// Source: http://www.codeproject.com/Articles/70223/Using-a-Service-Locator-to-Work-with-MessageBoxes
  /// </summary>
  public class ServiceContainer
  {
    #region Fields
    /// <summary>
    /// Service container instance of this service container implementation.
    /// </summary>
    public static readonly ServiceContainer Instance = new ServiceContainer();

    private readonly Dictionary<Type, object> mServiceMap;
    private readonly object mServiceMapLock;
    #endregion Fields

    #region constructor
    private ServiceContainer()
    {
      this.mServiceMap = new Dictionary<Type, object>();
      this.mServiceMapLock = new object();
    }
    #endregion constructor

    #region methods
    /// <summary>
    /// Add a service into this service container.
    /// </summary>
    /// <typeparam name="TServiceContract"></typeparam>
    /// <param name="implementation"></param>
    public void AddService<TServiceContract>(TServiceContract implementation)
        where TServiceContract : class
    {
      lock (this.mServiceMapLock)
      {
        this.mServiceMap[typeof(TServiceContract)] = implementation;
      }
    }

    /// <summary>
    /// Get a service that was previoulsy added into the service container.
    /// </summary>
    /// <typeparam name="TServiceContract"></typeparam>
    /// <returns></returns>
    public TServiceContract GetService<TServiceContract>()
        where TServiceContract : class
    {
      object service;

      lock (this.mServiceMapLock)
      {
        this.mServiceMap.TryGetValue(typeof(TServiceContract), out service);
      }

      return service as TServiceContract;
    }
    #endregion methods
  }
}
