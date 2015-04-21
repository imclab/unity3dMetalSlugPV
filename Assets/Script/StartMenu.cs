using UnityEngine;
using System.Collections;
//菜单脚本
public class StartMenu : MonoBehaviour {

	// Use this for initialization
    public string sceneName = "SelectCharacter";
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadScene()
    {
        Application.LoadLevel(sceneName);
    }
}
