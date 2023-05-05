using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManger : MonoBehaviour
{
	PlayerController player;
    public Image greenimage;
    public Image orangeimage;
    public Image yellowimage;
    private void Start()
	{
		player = GetComponent<PlayerController>();
	}
    public void Greenbtn()
    {
        GameManager.Instance.Green = true;
        GameManager.Instance.yellow = false;
        GameManager.Instance.Orange = false;
        Debug.Log(" Ui Green");
        greenimage.color = new Color(1, 1, 1, 1); // set green image alpha to 0.5
        orangeimage.color = new Color(1, 1, 1, 0.5f); // set orange image alpha to 1
        yellowimage.color = new Color(1, 1, 1, 0.5f);
    }
    public void Orangebtn()
    {
        GameManager.Instance.Orange = true;
        GameManager.Instance.yellow = false;
        GameManager.Instance.Green = false;
        greenimage.color = new Color(1, 1, 1, 0.5f); // set green image alpha to 0.5
        orangeimage.color = new Color(1, 1, 1, 1); // set orange image alpha to 1
        yellowimage.color = new Color(1, 1, 1, 0.5f);
    }
    public void Yellowbtn()
    {
        GameManager.Instance.yellow = true;
        GameManager.Instance.Green = false;
        GameManager.Instance.Orange = false;
        greenimage.color = new Color(1, 1, 1, 0.5f); // set green image alpha to 0.5
        orangeimage.color = new Color(1, 1, 1, 0.5f); // set orange image alpha to 1
        yellowimage.color = new Color(1, 1, 1, 1);
    }

    public void gobtn()
	{
        GameManager.Instance.Go = true;
	}
	public void Restart()
	{
		// Get the current scene
		Scene currentScene = SceneManager.GetActiveScene();

		// Load the current scene again
		SceneManager.LoadScene(currentScene.buildIndex);
	}
	public void delete()
	{
		GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("spray");

		foreach (GameObject obj in objectsWithTag)
		{
			Destroy(obj);
		}
	}public void Home()
	{
		SceneManager.LoadScene(0);
	}public void next()
	{
		int index = SceneManager.GetActiveScene().buildIndex;
		Debug.Log(index);
		SceneManager.LoadScene(index + 1);
	}
}
