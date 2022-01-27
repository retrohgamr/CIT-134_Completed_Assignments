//      retohGamr
//      12/6/21
//      Final Project CIT 134

using UnityEngine;
using UnityEngine.UIElements;

public class RockController : MonoBehaviour
{
    private UIController uiController;
    private Transform collisionBox;
    private Transform collideBoxRotationAnchor;
    private Collider collisionBoxCollider;
    private Collider fieldCollider;
    private Rigidbody armRigidBody;
    //private RigidbodyConstraints freezeRotation;
    private RigidbodyConstraints unlockRotationY;
    private Vector3 collisionBoxRotationAxis;
    private float upRotationMax;
    private float downRotationMax;
    private short rotSpeed;
    public bool groundCollision;
    private bool rockReleased;
    private string keyBoardInput;

    // Start is called before the first frame update
    private void Start()
    {
        collideBoxRotationAnchor = GameObject.Find("collideBoxRotationAnchor").GetComponent<Transform>();
        fieldCollider = GameObject.Find("Field").GetComponent<Collider>();
        collisionBox = GameObject.Find("collideBox1").GetComponent<Transform>();
        collisionBoxCollider = GameObject.Find("collideBox1").GetComponent<Collider>();
        armRigidBody = GameObject.Find("arm").GetComponent<Rigidbody>();
        uiController = GameObject.Find("UIDocument").GetComponent<UIController>();

        //freezeRotation = RigidbodyConstraints.FreezeAll;  //use this to freeze trebuchet arm.
        unlockRotationY = RigidbodyConstraints.None |
                              RigidbodyConstraints.FreezePosition |
                              RigidbodyConstraints.FreezeRotationX |
                              RigidbodyConstraints.FreezeRotationZ;

        collisionBoxRotationAxis = new Vector3(1, 0, 0);

        downRotationMax = 270f;
        upRotationMax = 90f;
        rotSpeed = 5;

        rockReleased = false;
    }

    private void Update()
    {
        RockThrowController();
    }

    private void RockThrowController()
    {
        //stops rotation of collisionBox when upRotationMax or downRotationMax are reached
        if (Mathf.Approximately(collisionBox.eulerAngles.x, upRotationMax))
            RotateBack();
        else if (Mathf.Approximately(collisionBox.eulerAngles.x, downRotationMax))
            RotateForward();

        keyBoardInput = Input.inputString;
        switch (keyBoardInput)
        {
            //controls
            case " ":
                armRigidBody.constraints = unlockRotationY;
                rockReleased = true;
                break;

            case "w":
                if (!rockReleased)
                    RotateForward();
                break;

            case "s":
                if (!rockReleased)
                    RotateBack();
                break;
        }
    }

    private void RotateForward()
    {
        collisionBox.RotateAround(collideBoxRotationAnchor.transform.position, collisionBoxRotationAxis, rotSpeed);
    }

    private void RotateBack()
    {
        collisionBox.RotateAround(collideBoxRotationAnchor.transform.position, collisionBoxRotationAxis, -rotSpeed);
    }

    private void OnTriggerStay(Collider other)
    {
        //Release Rock by destroying hingeJoint when collides with this
        if (other == fieldCollider && rockReleased)
        {
            uiController.newThrowBtn.style.display = DisplayStyle.Flex;
            groundCollision = true;
            PlayerPrefs.Save();
        }
        else if (other == collisionBoxCollider && rockReleased)
        {
            Destroy(this.GetComponent<HingeJoint>());
        }
    }
}