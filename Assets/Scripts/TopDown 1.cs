using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int result = Sum(35, 2, "ჯამი უდრის: ");
        Debug.Log(result);
    }
 private int Sum(int a, int b, string massage)
    {
    int result = a + b;
    return result;
    }

}