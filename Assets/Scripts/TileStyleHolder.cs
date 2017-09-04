using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Which means we will see our styles in unity inspector
[System.Serializable]
public class TileStyle {
	public int Number;
	public Color32 TileColor;
	public Color32 TextColor;
}

public class TileStyleHolder : MonoBehaviour {

	// Singleton
	public static TileStyleHolder Instance;

	public TileStyle[] TileStyles;

	void Awake() {
		Instance = this;
	}

}
