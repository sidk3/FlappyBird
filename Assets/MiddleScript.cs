using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LogicScript ls;
    void Start()
    {
        ls = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ls.addScore();
    }
}
