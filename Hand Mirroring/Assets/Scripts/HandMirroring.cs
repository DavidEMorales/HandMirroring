using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class HandMirroring : MonoBehaviour
{
    public Transform[] originalLeftHand;
    public Transform[] originalRightHand;
    public Transform[] mirroredLeftHand;
    public Transform[] mirroredRightHand;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < originalLeftHand.Length; i++) {
            mirroredLeftHand[i].localPosition = originalLeftHand[i].localPosition;
            mirroredLeftHand[i].localRotation = originalLeftHand[i].localRotation;
        }
        
        for (int i = 0; i < originalRightHand.Length; i++)
        {
            mirroredRightHand[i].localPosition = originalRightHand[i].localPosition;
            mirroredRightHand[i].localRotation = originalRightHand[i].localRotation;
        }

    }
    
}
