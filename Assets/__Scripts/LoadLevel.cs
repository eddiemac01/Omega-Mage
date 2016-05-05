using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
			Application.LoadLevel ("__OmegaMage_Scene_0");
	
	}
}
