using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{

    float _timer = 0;

    void Update()
    {
        _timer += Time.deltaTime;

        float x = Mathf.Cos(_timer);
        float y = Mathf.Sin(_timer);
        float z = 0;

        transform.position = new Vector3(x, y, z);
    }
}
