using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private float jumpStr;
    [SerializeField] private float gravityStr;
    public bool isOnGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityStr;
        
    }



    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpStr , ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
