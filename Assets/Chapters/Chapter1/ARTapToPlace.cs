using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARTapToPlace : MonoBehaviour
{

    public GameObject gameObjectToInstantiate;

    private GameObject spawnObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;
    public AudioSource VoiceStuff;


    static List<ARRaycastHit> hits = new List<ARRaycastHit>();



    private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchposition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(index: 0).position;
            return true;
        }
        touchPosition = default;
        return false;

    }

    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchposition(out Vector2 touchPosition))
            return;

        if (_arRaycastManager.Raycast(screenPoint: touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            if (spawnObject == null)
            {
                spawnObject = Instantiate(gameObjectToInstantiate, hitPose.position, hitPose.rotation);
                spawnObject.transform.Rotate(0, -180, 0, Space.Self);
                VoiceStuff.Play();
            }
            else
            {
                spawnObject.transform.position = hitPose.position;
                
            }
        }
        
    }
}
