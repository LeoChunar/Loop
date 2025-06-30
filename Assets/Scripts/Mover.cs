using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    void Update()
    {
        transform.Translate(_speed * Vector3.forward * Time.deltaTime);
    }
}
