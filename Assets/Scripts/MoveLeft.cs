using UnityEngine;
using UnityEngine.InputSystem;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 30f;
   private Move playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<Move>();  //move is actually player controller script name since im a genius I named it move smh...
    }

    // Update is called once per frame
    void Update()
    {
            if (playerControllerScript.gameOver == false)
            {
             transform.Translate(Vector3.left * speed * Time.deltaTime);  
            }


              
    }
}
