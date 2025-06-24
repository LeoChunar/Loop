using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _scaleFactor;

    private bool _isScaling = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isScaling = !_isScaling;
        }

        if (_isScaling)
        {
            ScaleObject();
        }
    }

    private void ScaleObject()
    {
        transform.localScale += new Vector3(_scaleSpeed * _scaleFactor * Time.deltaTime,
         _scaleSpeed * _scaleFactor * Time.deltaTime, _scaleSpeed * _scaleFactor * Time.deltaTime);
    }
}
