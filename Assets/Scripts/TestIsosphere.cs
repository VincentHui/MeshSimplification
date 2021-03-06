using UnityEngine;
using System.Collections;

public class TestIsosphere : MonoBehaviour {
	public int recursionLevel = 2;
	
	private Mesh _mesh;

	void Awake () {
		Reset ();
	}

	void OnDestroy() {
		Destroy(_mesh);
	}

	public void Reset () {
		Destroy(_mesh);
		_mesh = IsoSphere.Create(recursionLevel);
		var meshFilter = GetComponent<MeshFilter>();
		meshFilter.mesh = _mesh;
	}
	
}
