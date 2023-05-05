using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovment : MonoBehaviour
{
	Animator anim;
	Rigidbody2D rb;
	private void Start()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}
	private void Update()
	{
		if(GameManager.Instance.Go)
		{
			gobtn();
		}
	}
	public void gobtn()
       {
        if (rb != null)
		{ 
            rb.constraints = RigidbodyConstraints2D.None;
			
        }
    }
}

