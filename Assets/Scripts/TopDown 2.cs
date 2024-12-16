using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TopDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sum(14,5, "ჯამი უდრის: ");
    }
private void Sum(int a, int b, string message)
{
    int result = a + b;
    Debug.Log(message + result);
}
  
}
