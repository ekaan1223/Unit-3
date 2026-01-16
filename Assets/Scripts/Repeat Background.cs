using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    [SerializeField] private Vector3 startPos;
    private float repeatWidth;
    /*[SerializeField] private float offset;*/             /*my solution method is extremely usable too but i mean there is a better way to do it i guess*/
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;  
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)                                /*/ - offset) /*/
        {
            transform.position = startPos;
        }
    }
}
