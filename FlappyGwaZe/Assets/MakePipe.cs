using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float timediff;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = new Vector3(0, Random.Range(3f, 9f), 0);
            timer= 0;
            Destroy(newpipe, 7.0f);
        }
    }
}
