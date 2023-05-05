using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    //public PlayerController player;
    public GameObject Greenobj;
    public GameObject Yellowobj;
    public GameObject Orangeobj;

    private Vector3 mousePosition;
    [HideInInspector]
   public List<GameObject> instantiatedObject = new List<GameObject>();
  

    private void Update()
    {
        if (GameManager.Instance.Green == true)
		{
            instinate(Greenobj);
            GameManager.Instance.yellow = false;
            GameManager.Instance.Orange = false;
            Debug.Log(" Controller Green");
        }
         if (GameManager.Instance.Orange == true)
		{
            instinate(Orangeobj);
            GameManager.Instance.yellow = false;
            GameManager.Instance.Green = false;
            Debug.Log(" Controller Green");
        }
        if (GameManager.Instance.yellow == true)
		{
            instinate(Yellowobj);
            GameManager.Instance.Green = false;
            GameManager.Instance.Orange = false;
            Debug.Log(" Controller Green");
        }

    }
    private void instinate( GameObject obj)
	{
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in screen space
            mousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            // Calculate the distance the mouse has moved
            Vector3 delta = Input.mousePosition - mousePosition;

            // If the mouse has moved a certain distance, instantiate the object
            if (delta.magnitude > 5)
            {
                // Convert the mouse position to world space
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                worldPosition = new Vector3(worldPosition.x, worldPosition.y, 0);
                // Instantiate the object at the mouse position
                instantiatedObject.Add(Instantiate(obj, worldPosition, Quaternion.identity));
            }
        }
    }
}

