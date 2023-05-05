using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelselect : MonoBehaviour
{
    public int levelNumber;
    public GameObject imgLock, imgOpen, imgPass;
 
  
    void Start()
    {
        Debug.Log("GaneManger.Instance.getlevel()  " + GameManager.Instance.getlevel());
        for (int i=levelNumber; i <= GameManager.Instance.getlevel()+1; i++)
		{
            Debug.Log("levelNumbe  " +levelNumber);
           
            imgLock.SetActive(false);
            imgOpen.SetActive(true);
            imgPass.SetActive(true);
            GetComponent<Button>().interactable = true;
		}
    }

    public void loadscene()
	{
        Debug.Log("clicked" + levelNumber);
        GameManager.playingLevel = levelNumber;
        mainmenu.instance.loadscene(GameManager.playingLevel);
	}
  
   
}
