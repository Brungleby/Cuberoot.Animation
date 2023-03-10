
/** AnimScript.cs
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

namespace Cuberoot.Animation
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>

	[DefaultExecutionOrder(100)]

	public abstract class AnimScript : MonoBehaviour
	{
		protected virtual void OnValidate() { }
		protected virtual void Awake() { OnValidate(); }
	}
}
