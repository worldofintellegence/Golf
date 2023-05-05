using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
	public GameObject overscreen;

	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Ball"))
		{
			Destroy(collision.gameObject);

            GameManager.Instance.setlevel(GameManager.Instance.getlevel() + 1);
			overscreen.SetActive(true);
		}

	}
}
