using UnityEngine;

public class Transfrom : MonoBehaviour
{
    internal static object position;

    // Start is called before the first frame update
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.position += Vector3.left  * 2.0f;
            Debug.Log("good");
            
            
        }
        
    }

    
}
