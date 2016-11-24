using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public GameObject target;

    void Start()
    {
        Invoke("ChangeToScene",30);
    }

	
	 void  ChangeToScene (string scenceToChangeTo) {
        SceneManager.LoadScene(scenceToChangeTo);
	}
	
		
}
