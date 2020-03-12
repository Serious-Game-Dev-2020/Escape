using UnityEngine;

public class Transfrom : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.position += Vector3.left  * 1.0f;
            Debug.Log("good");
        }
    }

    
}
