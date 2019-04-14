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
		//--Конструкторы/инициализаторы-----------------
		// --
		//----------------------------------------------

		/// <summary>
		/// Сервис сетевого взаимодействия.
		/// </summary>
		public ServiceNetwork()
		{
			m_SettingsServer = new SettingsNetworkModel() { IP = "127.0.0.1", Port = 4000};
		}
		/// <summary>
		/// Сервис сетевого взаимодействия.
		/// </summary>
		public ServiceNetwork(SettingsNetworkModel SettingsServer)
		{
			m_SettingsServer = SettingsServer;
		}


		//--Свойства------------------------------------
		// --
		//----------------------------------------------

		/// <summary>
		/// Сервер приема передачи файлов.
		/// </summary>
		private NetworkServer m_Server;
		/// <summary>
		/// Настройки сервера.
		/// </summary>
		private SettingsNetworkModel m_SettingsServer;
		/// <summary>
		/// Настройки клиента.
		/// </summary>
		private SettingsNetworkModel m_SettingsClient;


		//--События-------------------------------------
		// --
		//----------------------------------------------

		/// <summary>
		/// -
		/// </summary>


		//--Методы--------------------------------------
		// --
		//----------------------------------------------

		/// <summary>
		/// Запустить сервер.
		/// </summary>
		public void StartServer()
		{			
			if (m_Server != null) m_Server = new NetworkServer();
			m_Server.Start(m_SettingsServer);
		}
	}
}
