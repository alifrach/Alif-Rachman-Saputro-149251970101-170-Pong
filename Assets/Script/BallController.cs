using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
<<<<<<< Updated upstream
    public Vector2 speed;
=======
    public Vector2 speed, resetPosition;
>>>>>>> Stashed changes
    private Rigidbody2D rig;
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
<<<<<<< Updated upstream
=======
        speed = new Vector2(Random.Range(-7f, 7f), Random.Range(-5f, 5f));
>>>>>>> Stashed changes
        rig.velocity = speed;
    }

    // Update is called once per frame
    private void Update()
    {
    }

<<<<<<< Updated upstream
=======
    public void ActivatePUSpeedUp(float magnitude) 
    { 
        rig.velocity *= magnitude; 
    } 

    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2); 
        speed = new Vector2(Random.Range(-7f, 7f), Random.Range(-5f, 5f));
        rig.velocity = speed;
    } 
>>>>>>> Stashed changes
}
