using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    Camera mainCamera;

    [SerializeField]
    GameObject[] targets;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        
    }

    void Update()
    {
        if (targets[0] != null && targets[1] != null)
        {

            Vector2 lookPoint = Vector2.Lerp(targets[0].transform.position, targets[1].transform.position, 0.5f);
            mainCamera.transform.LookAt(lookPoint);

            mainCamera.transform.position = new Vector3(lookPoint.x, 0,-10);
            mainCamera.transform.localEulerAngles = new Vector2(0, 0);

            float distance = Vector2.Distance(targets[0].transform.position, targets[1].transform.position);
            if (distance > (mainCamera.orthographicSize * 2))
            {
                mainCamera.orthographicSize += 0.5f * Time.deltaTime;
                
                 if (distance < (mainCamera.orthographicSize * 2))
                {
                    mainCamera.orthographicSize -= 0.5f * Time.deltaTime;
                }
                
            }
            else if (distance < (mainCamera.orthographicSize) )
            {
                mainCamera.orthographicSize -= 0.5f * Time.deltaTime;
            }
        }

        if (mainCamera.orthographicSize < 5)
            mainCamera.orthographicSize = 5;

        if (mainCamera.orthographicSize > 15)
            mainCamera.orthographicSize = 15;



        
    }

}
