using UnityEngine;

public class Nukem : MonoBehaviour
{
    [SerializeField] float destroyObj = -7.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyObj)
        {
            Object.Destroy(gameObject);
        }
    }
}
