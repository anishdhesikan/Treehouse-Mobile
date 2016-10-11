using UnityEngine;
using System.Collections;

public class AppButton : MonoBehaviour {

	PlaceCube placeCube;

	// Use this for initialization
	void Start () {
		placeCube = FindObjectOfType<PlaceCube>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick () {
		if (placeCube == null) {
			placeCube = FindObjectOfType<PlaceCube>();
		}
		placeCube.PlaceGift();
	}
}
