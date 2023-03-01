
/** EyeTracker.cs
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

	public sealed class EyeTracker : MonoBehaviour
	{
		#region Fields

		[SerializeField]
		private Transform _UpContext;

		public float InterpolationSpeed = 10f;

		#endregion
		#region Members

		private Transform _Focus;

		#endregion
		#region Properties



		#endregion
		#region Methods

		public void Initialize(Transform focus)
		{
			_Focus = focus;
		}

		private void Update()
		{
			var __normal = (_Focus.position - transform.position).normalized;
			// normal = Quaternion.Euler(Vector3.right * 90f) * normal;

			var __forwardToUp = Quaternion.Euler(Vector3.right * 90f) * Quaternion.Euler(Vector3.up * 180f);
			var __target = Quaternion.LookRotation(__normal, _UpContext.up) * __forwardToUp;

			transform.rotation = Quaternion.SlerpUnclamped(transform.rotation, __target, InterpolationSpeed * Time.deltaTime);
		}

		#endregion
	}
}
