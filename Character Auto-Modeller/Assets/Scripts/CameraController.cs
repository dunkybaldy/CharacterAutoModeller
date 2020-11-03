using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AutoModeller {
    public class CameraController : MonoBehaviour
    {
        public float MovementSpeed = 5f;
        public float ZoomSpeed = 0.25f;
        public float RotationSpeed = 10f;

        private Vector3 MouseInitialPosition;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            MoveCamera();
            ZoomCamera();
        }

        private void MoveCamera()
        {
            if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)) // 0 left, 1 right, 2 middle
                MouseInitialPosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            if (Input.GetMouseButton(2)) // middle button held - movement
            {
                var currentMousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

                var mouseDiff = (MouseInitialPosition - currentMousePosition) * MovementSpeed;
                transform.Translate(mouseDiff, Space.Self);

                MouseInitialPosition = currentMousePosition;
            }

            if (Input.GetMouseButton(1)) // right button held - rotation
            {
                var currentMousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);

                var diff = (MouseInitialPosition - currentMousePosition) * RotationSpeed;
                transform.eulerAngles += new Vector3(diff.y, -diff.x, diff.z) * RotationSpeed; // Negative x rotates with the mouse movement

                MouseInitialPosition = currentMousePosition;
            }
        }

        private void ZoomCamera()
        {
            transform.Translate(0, 0, Input.mouseScrollDelta.y * ZoomSpeed, Space.Self);
        }
    }
}