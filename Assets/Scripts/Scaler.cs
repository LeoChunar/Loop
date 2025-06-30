using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _scaleFactor;

    private bool _isScaling = false;

    private void Update()
    {
            ScaleObject();
    }

    private void ScaleObject()
    {
        transform.localScale += Vector3.one * _scaleSpeed * _scaleFactor * Time.deltaTime;
    }
}
