using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhellContolerPL2 : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    public float aceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {

        currentAcceleration = aceleration * Input.GetAxis("Vertical-PL2");

        if (Input.GetKey(KeyCode.RightShift))
            currentBreakForce = breakingForce;

        else
            currentBreakForce = 0f;


        backLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;

        frontLeft.brakeTorque = currentBreakForce;
        frontRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal-PL2");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        updatewheel(frontLeft, frontLeftTransform);
        updatewheel(frontRight, frontRightTransform);
        updatewheel(backLeft, backRightTransform);
        updatewheel(backRight, backLeftTransform);
    }

    void updatewheel(WheelCollider col, Transform trans)
    {
        Vector3 Position;
        Quaternion rotation;
        col.GetWorldPose(out Position, out rotation);

        trans.position = Position;
        trans.rotation = rotation;
    }
}
