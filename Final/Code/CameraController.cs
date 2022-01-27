//      retohGamr
//      12/6/21
//      Final Project CIT 134

using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject rock;
    private Transform cameraControllerTransform;
    private Vector3 offSet;
    private Vector3 v = Vector3.zero;
    private Vector3 targetPosition;
    private float smoothTime;

    // Start is called before the first frame update
    private void Start()
    {
        rock = GameObject.Find("rock");
        cameraControllerTransform = this.transform;
        offSet = cameraControllerTransform.transform.position - rock.transform.position;
        smoothTime = 0.1f;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        AimCameraAtTarget();
    }

    private void AimCameraAtTarget()
    {
        targetPosition = rock.transform.position + offSet;
        cameraControllerTransform.transform.position = Vector3.SmoothDamp(cameraControllerTransform.transform.position, targetPosition, ref v, smoothTime);
        transform.LookAt(rock.transform);
    }
}