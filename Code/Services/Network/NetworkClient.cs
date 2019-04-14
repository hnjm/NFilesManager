using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace NFilesManager.Code.Services.Network
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class NetworkClient
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
        /// TCP сервер.
        /// </summary>
        TcpClient m_Client;
        #endregion

        #region События
        #endregion

        #region Методы
        /// <summary>
        /// Подключиться к серверу.
        /// </summary>
        public void Connect()
        {
            // -
            if (m_Client.Connected) m_Client.Close();
            // -
            IPAddress _IPAddress;
            int _Port;
            // -
            IPEndPoint _IPEndPoint = new IPEndPoint();
            // -
            string _Hostname;
            // -
            m_Client.Connect(;
        }
        #endregion
    }
}
