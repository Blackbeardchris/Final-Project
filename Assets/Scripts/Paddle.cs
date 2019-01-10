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

	public float MovementSpeed;
 
void Update()
{
   Vector3 direction = CalculateDirection();
   transform.Translate(direction * MovementSpeed * Time.deltaTime);
}
	public Vector3 CalculateDirection()
{
   Vector3 direction = Vector3.zero;
   if (Input.GetKey(KeyCode.W))
   {
     direction.y += 1.0f;
   }
   if (Input.GetKey(KeyCode.A))
   {
     direction.x -= 1.0f;
   }
   if (Input.GetKey(KeyCode.S))
   {
     direction.y -= 1.0f;
   }
   if (Input.GetKey(KeyCode.D))
   {
     direction.x += 1.0f;
   }
   return direction.normalized;
}


}
