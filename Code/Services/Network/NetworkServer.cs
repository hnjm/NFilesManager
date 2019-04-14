using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using NFilesManager.Code.Models;

namespace NFilesManager.Code.Services.Network
{
	/// <summary>
	/// Сервер.
	/// </summary>
	public class NetworkServer
	{
		#region Конструкторы/инициализаторы

		#endregion

		#region Свойства
		/// <summary>
		/// TCP сервер.
		/// </summary>
		TcpListener m_Server;
		#endregion

		#region События

		#endregion

		#region Методы
		/// <summary>
		/// 
		/// </summary>
		public void Start(SettingsNetworkModel Settings)
		{
			Start(IP: Settings.IP, Port: Settings.Port);
		}
		/// <summary>
		/// Запустить сервер.
		/// </summary>
		public void Start(string IP, int Port)
		{
			if (m_Server != null) m_Server.Stop();
			//
			IPAddress _IP = IPAddress.Parse(IP);
			m_Server = new TcpListener(localaddr: _IP, port: Port);
			//
			m_Server.Start();
		}
		/// <summary>
		/// Остановить сервер.
		/// </summary>
		public void Stop() { m_Server.Stop(); }
		#endregion
	}
}
