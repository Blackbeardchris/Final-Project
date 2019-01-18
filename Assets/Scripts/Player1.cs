using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
/* 
[SerializeField] int _attack = 6;
[SerializeField] int _maximumHealth = 100;
[SerializeField] int _int = 6;
[SerializeField] int hitRange = 1;
[SerializeField] int health = 100;
*/

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
/*   isClicked = false;
     if (gameObject.GetComponent(Collider) == null)
     {
        gameObject.AddComponent(typeof(BoxCollider));
     }
		theGameStatus = FindObjectOfType<GameStatus>();
		theBall = FindObjectOfType<Ball>();
    */
	}

	
	// Update is called once per frame

	public float MovementSpeed;
 
void Update()
{
  /* 
  if (Input.GetKey(KeyCode.R)) {
    Attack();
  }
  */
  //Vector3 cool = basicAttack();
  Vector3 direction = CalculateDirection();
  horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
  animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
  transform.Translate(direction * MovementSpeed * Time.deltaTime);

}
/*
void TakeDamage(int damageAmount)
 {
     health = health - damageAmount;
 
     // We should also check if the health is still greater than 0 
     // in order to determine whether enemy is still alive or not
 
     if(health < 0)
     {
         // This enemy is supposed to be dead now.
     }
 }
*/
/* void Attack() {
     if (Physics.Raycast(origin, forward, hitRange, out hit)) {
        if (hit.transform.gameObject.tag == "Enemy") {
            hit.transform.gameObject.SendMessage("TakeDamage", 30);
        }
    }
}
*/
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
