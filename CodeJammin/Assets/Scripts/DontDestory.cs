using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{
    private GameObject[] music;
	static DontDestory instance = null;
	void Start(){
 		music = GameObject.FindGameObjectsWithTag ("gameMusic");
 		Destroy (music[1]);
 	}
 	
 	// Update is called once per frame
 	void Awake () {
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}
   

