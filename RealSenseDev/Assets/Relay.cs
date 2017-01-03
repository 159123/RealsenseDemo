using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Relay : MonoBehaviour
{
    [SerializeField]
    private GameObject sliderObj;
    private Slider sliderScripts;

    [SerializeField]
    private GameObject rightHandsRS;
    private TrackingAction rightHandTracking;
    private Vector3 rightHandInitPos;
    private Vector3 rightHandRunPos;
    private float rightHandHorzScale;



    void Start()
    {
        sliderScripts = sliderObj.GetComponent<Slider>();
        sliderScripts.value = 0.0f;

        rightHandTracking = rightHandsRS.GetComponent<TrackingAction>();
        rightHandHorzScale = rightHandTracking.VirtualWorldBoxDimensions.x;
        rightHandInitPos = rightHandsRS.transform.position;
        rightHandRunPos = new Vector3(0.0f, 0.0f, 0.0f);
    }
    void Update()
    {
        rightHandRunPos = rightHandsRS.transform.position;
        sliderScripts.value = 0.5f + ((rightHandRunPos.x - rightHandInitPos.x) / rightHandHorzScale);
    }

}
