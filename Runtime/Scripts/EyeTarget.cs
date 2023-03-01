
/** EyeTarget.cs
*
*	Created by LIAM WOFFORD, USA-TX, for the Public Domain.
*
*	Repo: https://github.com/Brungleby/Cuberoot
*	Kofi: https://ko-fi.com/brungleby
*/

#region Includes

using System.Collections.Generic;

using UnityEngine;

using Cuberoot;

#endregion

namespace Dreamwalker.Animation
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>

	public sealed class EyeTarget : MonoBehaviour
	{
		#region Fields

		[SerializeField]
		private EyeTracker[] _Eyes;
		public EyeTracker[] Eyes => _Eyes;

		#endregion
		#region Members



		#endregion
		#region Properties



		#endregion
		#region Methods

		void Awake()
		{
			foreach (var i in _Eyes)
			{
				i.Initialize(transform);
			}
		}

		#endregion
	}
}
