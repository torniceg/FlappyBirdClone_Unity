using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float intervalTime;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervalTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(newPipe.transform.position.x, Random.Range(-2.0f, 4.0f), 0);
            timer = 0;
            Destroy(newPipe,6.0f);
        }
    }
}