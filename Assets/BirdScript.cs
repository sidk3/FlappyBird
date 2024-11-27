using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive==true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 19)
        {

            logic.gameOver();
            birdAlive = false;
        }
        if (transform.position.y < -18)
        {
            logic.gameOver();
            birdAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }
}
