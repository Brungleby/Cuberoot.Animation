
/** BlendBoneLinkAsset.cs
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
	/// This asset provides a way to link bone animation directly to blendshapes.
	///</summary>

	[CreateAssetMenu(menuName = "Cuberoot/Animation/Blend Bone Link Asset", fileName = "New Blend Bone Link Asset")]

	public sealed class BlendBoneLinkAsset : ScriptableObject
	{
		[System.Serializable]
		public struct BoneLink
		{
			public string BoneName;
			public ESignedAxis BoneAxis;
		}

		#region Fields

		[SerializeField]

		public string ShapePrefix = string.Empty;

		[SerializeField]

		public string BonePrefix = string.Empty;

		[SerializeField]

		public MapField<string, BoneLink> Links;

		#endregion
		#region Members



		#endregion
		#region Properties



		#endregion
		#region Methods

		public BlendBoneLinkInstance CreateInstance(in Transform root, SkinnedMeshRenderer mesh) =>
			new BlendBoneLinkInstance(this, root, mesh);

		#endregion
	}

	public sealed class BlendBoneLinkInstance : object
	{
		#region Construction

		public BlendBoneLinkInstance(BlendBoneLinkAsset template, Transform root, SkinnedMeshRenderer mesh)
		{
			// Mesh = mesh;

			// Links = new (string, Transform)[template.Links.Count];
			// List<string> keys = (List<string>)template.Links.Keys;

			// for (var i = 0; i < Links.Length; i++)
			// {
			// 	string __linkName = keys[i];
			// 	string __shapeName = template.ShapePrefix + __linkName;
			// 	string __boneName = template.BonePrefix + __linkName;

			// 	Links[i] = (__shapeName, root.Find(__boneName));
			// }
		}

		#endregion
		#region Members

		private (string, Transform)[] Links;
		private SkinnedMeshRenderer Mesh;

		#endregion
		#region Methods

		// public void Update()
		// {
		// 	for (var i = 0; i < Links.Length; i++)
		// 	{
		// 		Mesh.SetBlendShapeWeight(i, Evaluate(i));

		// 	}
		// }

		// public float Evaluate(int index)
		// {
		// 	return Links[index].Item2.position.x;
		// }

		#endregion
	}
}
