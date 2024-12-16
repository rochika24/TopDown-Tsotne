using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sun(10,7,"სხვაობა უდრის");
    }
private void Sun(int a, int b, string message)
{
    int result = a - b;
    Debug.Log(message + result);
}  
}
