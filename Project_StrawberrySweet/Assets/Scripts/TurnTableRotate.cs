using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTableRotate: MonoBehaviour {
    [Range(0.0f, 100.0f)]
    public float maxRotateSpeed = 50.0f;
    [Range(1, 100)]
    public int smoothRotate = 20;

    private float currentRotateSpeed=0.0f;
    
    // Class For Rotate 
	
    public void Rotate()
    {
        if(currentRotateSpeed < maxRotateSpeed)
        {
            currentRotateSpeed = Mathf.Lerp(currentRotateSpeed, maxRotateSpeed, smoothRotate);

            // z轴逆时针旋转
            gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, currentRotateSpeed * Time.deltaTime));
        }
    }

    public void StopRotate()
    {
        if(currentRotateSpeed > 0.0f)
        {
            currentRotateSpeed = Mathf.Lerp(currentRotateSpeed, 0.0f, smoothRotate);

            gameObject.transform.Rotate(new Vector3(0.0f, 0.0f, currentRotateSpeed * Time.deltaTime));
        }
    }

}
