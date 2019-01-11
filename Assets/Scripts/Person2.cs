using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person2 : MonoBehaviour {

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
   if (Input.GetKey(KeyCode.UpArrow))
   {
     direction.y += 1.0f;
   }
   if (Input.GetKey(KeyCode.LeftArrow))
   {
     direction.x -= 1.0f;
   }
   if (Input.GetKey(KeyCode.DownArrow))
   {
     direction.y -= 1.0f;
   }
   if (Input.GetKey(KeyCode.RightArrow))
   {
     direction.x += 1.0f;
   }
   return direction.normalized;
}


}
//just to push
