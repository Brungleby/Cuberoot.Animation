
/** OneShotParams.cs
*
*	Created by LIAM WOFFORD of CUBEROOT SOFTWARE, LLC.
*
*	Free to use or modify, with or without creditation,
*	under the Creative Commons 0 License.

*/

#region Includes

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

#endregion

namespace Cuberoot
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>

	public sealed class OneShotParams : MonoBehaviour
	{
		#region Fields

		[SerializeField]
		private Cuberoot.Modules.Pawn _Pawn;
		public Cuberoot.Modules.Pawn Pawn => _Pawn;

		public ParticleSystem Particle;
		public AudioSource Audio;

		public float MaxLifetime = 10f;

		[SerializeField]
		private AnimationCurve _VolumeBySpeed = AnimationCurve.Constant(0f, 1f, 1f);

		#endregion

		#region Properties

		public float volumeBySpeed => _VolumeBySpeed.Evaluate(_Pawn.speed);

		#endregion
		#region Methods

		private void Awake()
		{
			Destroy(gameObject, MaxLifetime);

			if (_Pawn != null)
				Audio.volume = volumeBySpeed;
		}

		#endregion
	}
}
