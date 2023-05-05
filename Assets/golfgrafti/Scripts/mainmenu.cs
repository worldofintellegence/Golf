using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
	public GameObject startmenu, information, setting, levels,loadingscreen;
    public static mainmenu instance;
	float rotationtme = 5f;
	float rotationtimer = 0.0f;
	bool abc = true;
    [Header("Sound and Music")]
    public Image soundImage;
    public Image musicImage;
    public Sprite soundImageOn, soundImageOff, musicImageOn, musicImageOff;
  
    void Awake()
    {
       
        /*soundManager = FindObjectOfType<SoundManager>();*/
    }
    public void Start()
    {
        instance = this;
        startmenu.SetActive(false);
        information.SetActive(false);
        setting.SetActive(false);
        levels.SetActive(false);
        loadingscreen.SetActive(true);
        // SoundManager.PlayMusic(SoundManager.Instance.musicsMenu);
        SoundManager.PlayGameMusic();
        StartCoroutine(Loading());



    }
    #region Music and Sound
    public void TurnSound()
    {
        GameManager.Instance.isSound = !GameManager.Instance.isSound;
        soundImage.sprite = GameManager.Instance.isSound ? soundImageOff : soundImageOn;
        SoundManager.SoundVolume = GameManager.Instance.isSound ? 0 : 1;
        PlayerPrefs.SetFloat("sound", SoundManager.SoundVolume);
        
    }

    public void TurnMusic()
    {
        GameManager.Instance.isSound = !GameManager.Instance.isSound;
        musicImage.sprite = GameManager.Instance.isSound ? musicImageOff : musicImageOn;
        SoundManager.MusicVolume = GameManager.Instance.isSound ? 0 : 1;
        PlayerPrefs.SetFloat("Music", SoundManager.MusicVolume);
    }
    #endregion
   
    public void play()
    {
        SoundManager.Click();

        startmenu.SetActive(false);
        SceneManager.LoadScene(GameManager.Instance.getlevel() + 1);
    }
    public void level()
	{
        SoundManager.Click();
        levels.SetActive(true);
		startmenu.SetActive(false);

	}
	public void Information()
	{
        SoundManager.Click();
        information.SetActive(true);
		startmenu.SetActive(false);

	}
	public void seetting()
	{
        SoundManager.Click();
        setting.SetActive(true);
		startmenu.SetActive(false);
	}public void back()
	{
        SoundManager.Click();
        setting.SetActive(false);
		information.SetActive(false);
		levels.SetActive(false);
		loadingscreen.SetActive(false);
		startmenu.SetActive(true);
	}
    public void loadscene(int number)
    {

        levels.SetActive(false);
        loadingscreen.SetActive(true);

        SceneManager.LoadScene(number);
    }
    
    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2f);

        loadingscreen.SetActive(false);
        
            startmenu.SetActive(true);
        

    }

}
