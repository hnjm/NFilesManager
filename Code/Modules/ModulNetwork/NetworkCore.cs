using System.Collections.Generic;

namespace NFilesManager.Code.Modules.ModulNetwork
{
    /// <summary>
    /// Сервис сетевого взаимодействия.
    /// </summary>
    class NetworkCore : IModulNetwork
    {
        #region Конструкторы/инициализаторы
        public static IModulNetwork Instance(SettingsNetworkModel SettingsServer = null)
        {
            NetworkCore _Core = SettingsServer == null ? new NetworkCore() : new NetworkCore(SettingsServer);
            return _Core;
        }

        /// <summary>
        /// Сервис сетевого взаимодействия.
        /// </summary>
        private NetworkCore()
        {
            m_SettingsServer = new SettingsNetworkModel() { IP = "127.0.0.1", Port = 4000 };
            m_Clients = new List<NetworkClient>();
        }
        /// <summary>
        /// Сервис сетевого взаимодействия.
        /// </summary>
        private NetworkCore(SettingsNetworkModel SettingsServer)
        {
            m_SettingsServer = SettingsServer;
            m_Clients = new List<NetworkClient>();
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Сервер приема передачи файлов.
        /// </summary>
        private NetworkServer m_Server;
        /// <summary>
        /// Настройки сервера.
        /// </summary>
        private readonly SettingsNetworkModel m_SettingsServer;
        /// <summary>
        /// Подключения к клиентам.
        /// </summary>
        private readonly List<NetworkClient> m_Clients;
        #endregion

        #region События
        #endregion

        #region Методы
        /// <summary>
        /// Запустить сервер.
        /// </summary>
        public void StartServer()
        {
            if (m_Server != null) m_Server = new NetworkServer();
            m_Server.Start(m_SettingsServer);
        }
        /// <summary>
        /// Остановить сервер.
        /// </summary>
        public void StopServer()
        {
            m_Server.Stop();
        }
        /// <summary>
        /// Создать подключение к клиенту.
        /// </summary>
        /// <param name="Hostname">Хост клиента.</param>
        /// <param name="Port">Порт.</param>
        public INetworkClient Connect(string Hostname, int Port)
        {
            // Создать клиент.
            NetworkClient _Client = new NetworkClient();
            // Выполнить подключение.
            _Client.Connect(Hostname, Port);
            // Добавить подключение в список.
            m_Clients.Add(_Client);
            // -
            return _Client;
        }
        #endregion
    }
}
