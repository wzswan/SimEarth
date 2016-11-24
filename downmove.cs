using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class downmove : MonoBehaviour {

    //public GameMaster gameman;

    //This is the object you want to move
    public GameObject GvrMain;
    //Start
    private Vector3 startPos;
    //End
    private Vector3 endPos;
    //Distance
    private float distance = 260f;

    public bool moveForward;

   // public float toggleAngle = 30.0f;

    //public Transform vrCamera;

    //Time to take from start to end
    private float lerpTime = 50;
    //This will update the lerp time
    private float currentLerpTime = 0;

    //private bool keyHit = false;
  

    // Use this for initialization
    void Start () {
        startPos = GvrMain.transform.position;
        endPos = GvrMain.transform.position + Vector3.down * distance;
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.AI))
       // {
        //    keyHit = true;
       // }
	   // if (keyHit == true)
       // {
      // if(vrCamera.eulerAngles.x >=toggleAngle && vrCamera.eulerAngles.x < 90.0f)
       // {
      //      moveForward = true;
      //  }
      //  else
      //  {
      //      moveForward = false;
      //  }
      //  if (moveForward)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            float Perc = currentLerpTime / lerpTime;
            GvrMain.transform.position = Vector3.Lerp(startPos, endPos, Perc);

            if (currentLerpTime == lerpTime)
            {
                SceneManager.LoadScene("badEnd");
            }
        }
       }
	}

