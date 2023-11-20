using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPOCO.Generic {

	/// <summary>
	/// Clase genérica de la cual heredan todas las clases generadas por el template T4.
	/// Permite asignar funcionalidad general a todos los POCOs.
	/// </summary>
	public abstract class GenericPoco {

		/// <summary>
		/// Propiedad utilizada para indicar que una instancia de esta clase ha sido marcada.
		/// Esta propiedad no está mapeada desde la BD.
		/// </summary>
		public bool Marcado { get; set; }


		/// <summary>
		/// Copia el objeto actual en un objeto nuevo pasado por parametro.
		/// </summary>
		/// <param name="targetObject"></param>
		public void CopyTo(object targetObject) {
			foreach (var pS in this.GetType().GetProperties()) {
				foreach (var pT in targetObject.GetType().GetProperties()) {
					if (pT.Name != pS.Name) continue;
					try {
						(pT.GetSetMethod()).Invoke(targetObject, new object[] { pS.GetGetMethod().Invoke(this, null) });
					}
					catch {
					}
				}
			};
		}

	}
}