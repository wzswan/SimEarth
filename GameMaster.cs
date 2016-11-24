using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {
    public int score;
    private object SenceMager;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(score == 3)
        {
            SceneManager.LoadScene("goodEnd");
            
        }
	
	}

    public void AddPoints(int points)
    {
        score += points;
    }

    
   
}
