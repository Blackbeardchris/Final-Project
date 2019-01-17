using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	// configuration parameters
	[SerializeField] float minX = 1f;
	[SerializeField] float maxX = 16.63f;
	[SerializeField] float screenWidthInUnits = 16.63f;

	//cache refs
	GameStatus theGameStatus;
	Ball theBall;


    // animation thingys
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    public SpriteRenderer mySpriteRenderer;
	

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
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
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
//just to push
