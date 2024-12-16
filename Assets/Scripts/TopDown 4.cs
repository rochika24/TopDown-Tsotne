using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Multi(10,7,"ნამრავლი უდრის: ");
    }
private void Multi(int a, int b, string message)
{
    int result = a * b;
    Debug.Log(message + ""+result);
}
  
}
