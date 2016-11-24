using UnityEngine;
using System.Collections;


public class BoxDestory : MonoBehaviour {

    public GameMaster gameman;

    //public GameObject gameMaster;
    //GameMaster gameman;
    public int partPoints = 1;

	// Use this for initialization
	void Start () {

       // gameman = gameMaster.GetComponent<GameMaster>();
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
    public void Destory()
    {
        //GameMaster.currentScore += 1;
        gameman.AddPoints(partPoints);
        Destroy(gameObject);
    }
}
