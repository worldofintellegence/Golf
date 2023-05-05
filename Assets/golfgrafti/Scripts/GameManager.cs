using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance;
	[HideInInspector]
	public bool Green, Orange, yellow;
	public bool Go;
	public bool loading = true;
    public  bool isSound = true ;
    public  bool isMusic = true ;
    public static int playingLevel = -1;
	private void Awake()
	{

		Instance = this;
	}
	private void Start()
	{
		
		


	}
	public void setlevel(int value)
	{
		PlayerPrefs.SetInt("level", value);
	}public int getlevel()
	{
		
		return PlayerPrefs.GetInt("level");
	}
}
