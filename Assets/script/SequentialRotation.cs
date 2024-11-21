using System.Collections;
using UnityEngine;

public class SequentialRotation : MonoBehaviour
{
    public Transform[] cubes;
    public float baseRotationSpeed = 150f;
    public float speedMultiplier = 200f;
    public float secondCubeSpeedBoost = 150f;
    public float delayBetweenRotations = 0.1f;
    private int currentCubeIndex = 0;
    private float timer = 0f;

    private void Update()
    {

        timer += Time.deltaTime;

        if (currentCubeIndex < cubes.Length && timer >= delayBetweenRotations)
        {

            float rotationSpeed;


            if (currentCubeIndex == 1)
            {
                rotationSpeed = baseRotationSpeed + secondCubeSpeedBoost;
            }
            else
            {
                rotationSpeed = baseRotationSpeed + (cubes.Length - currentCubeIndex) * speedMultiplier;
            }


            RotateCube(cubes[currentCubeIndex], rotationSpeed);

            currentCubeIndex++;


            timer = 0f;
        }
    }

    private void RotateCube(Transform cube, float rotationSpeed)
    {

        cube.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
