using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
     float speed = 100.0f;
     float rotationtme = 5f;
     float rotationtimer = 0.0f;
     public bool loadscene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        rotationtimer += Time.deltaTime;
        float rotationangle = rotationtimer * speed;
        if(rotationtimer< rotationtme)
		{
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, -rotationangle);

		}
		
    }
}
