using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using NFilesManager.Code.Models;

namespace NFilesManager.Code.Services.Network
{
	/// <summary>
	/// Сервис сетевого взаимодействия.
	/// </summary>
	public class ServiceNetwork
	{
        #region Конструкторы/инициализаторы
        /// <summary>
        /// Сервис сетевого взаимодействия.
        /// </summary>
        public ServiceNetwork()
        {
            m_SettingsServer = new SettingsNetworkModel() { IP = "127.0.0.1", Port = 4000 };
            m_Clients = new List<NetworkClient>();
        }
        /// <summary>
        /// Сервис сетевого взаимодействия.
        /// </summary>
        public ServiceNetwork(SettingsNetworkModel SettingsServer)
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
        private SettingsNetworkModel m_SettingsServer;
        /// <summary>
        /// Подключения к клиентам.
        /// </summary>
        private List<NetworkClient> m_Clients;
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
