using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{

    public Slider rot;
    public float val;
    
    private void FixedUpdate() {
        val = (float)rot.value;
        Debug.Log(val);
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0,val,0));
    }
}
