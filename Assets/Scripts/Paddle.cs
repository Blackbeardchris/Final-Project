using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// configuration parameters
	[SerializeField] float minX = 1f;
	[SerializeField] float maxX = 16.63f;
	[SerializeField] float screenWidthInUnits = 16.63f;

	//cache refs
	GameStatus theGameStatus;
	Ball theBall;

	// Use this for initialization
	void Start () {
		theGameStatus = FindObjectOfType<GameStatus>();
		theBall = FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 paddlePos = new Vector2 (transform.position.x, transform.position.y);
		paddlePos.x = Mathf.Clamp(GetXPos() , minX , maxX);
		transform.position = paddlePos;
		//above transforms/moves paddle
	}

	private float GetXPos() {
		if (theGameStatus.IsAutoPlayEnabled()) {
			return theBall.transform.position.x;
		}
		else {
			return Input.mousePosition.x / Screen.width * screenWidthInUnits; 
		}
	}
}
