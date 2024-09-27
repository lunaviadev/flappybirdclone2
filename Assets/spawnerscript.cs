using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public float maxTime = 1;
    public float height;
    private float timer = 0;
    public GameObject PipeParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {

            GameObject newPipe = Instantiate(PipeParent);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    
}
