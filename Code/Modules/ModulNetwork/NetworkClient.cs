using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using NFilesManager.Code.Models;
using NFilesManager.Code.Modules.ModulGeneral;

namespace NFilesManager.Code.Modules.ModulNetwork
{
    /// <summary>
    /// Клиент.
    /// </summary>
    class NetworkClient: INetworkClient
    {
        #region Конструкторы/инициализаторы
        /// <summary>
        /// Создать клиент.
        /// </summary>
        public NetworkClient()
        {
            m_Client = new TcpClient();
        }
        #endregion

        #region Свойства
        /// <summary>
        /// Состояние подключения.
        /// </summary>
        public bool Connected { get { return m_Client.Connected; } }

        /// <summary>
        /// TCP сервер.
        /// </summary>
        private TcpClient m_Client;
        #endregion

        #region События
        #endregion

        #region Методы
        /// <summary>
        /// Подключиться к серверу.
        /// </summary>
        public void Connect(string Hostname, int Port)
        {
            // Закрыть предыдущее подключение.
            if (m_Client.Connected) m_Client.Close();
            // Создать новое подключение.
            m_Client = new TcpClient();
            m_Client.Connect(Hostname, Port);
        }
        /// <summary>
        /// Закрыть подключение.
        /// </summary>
        public void Close()
        {
            m_Client.Close();
        }
        #endregion
    }
}
