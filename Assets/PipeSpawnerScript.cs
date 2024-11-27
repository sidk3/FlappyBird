using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnRate =5;
    private float timer = 0;
    public float heightOffset = 10;
    public float pipeSpacing = 10;
    public float nextSpawnX;
    void Start()
    {
        nextSpawnX = transform.position.x;
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(nextSpawnX,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
        nextSpawnX += pipeSpacing;
    }
}
