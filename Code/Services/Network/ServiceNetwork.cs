using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

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
		/// -
		/// </summary>


		//--Свойства------------------------------------
		// --
		//----------------------------------------------

		/// <summary>
		/// Сервер приема передачи файлов.
		/// </summary>
		private NetworkServer m_Server;

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

		}
	}
}
