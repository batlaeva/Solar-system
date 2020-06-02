using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalCharacteristics : MonoBehaviour
{
    public GameObject[] objects;    //Солнце и планеты по порядку
    // float[] scale = new float[9] {109f, 0.383f, 0.949f, 1f, 0.532f, 11.21f, 9.45f, 4.01f, 3.88f};
    // float[] positionX = new float[9] {0f, 57.9f, 108.2f, 149.6f, 227.9f, 778.6f, 1433.5f, 2872.5f, 4495.1f};
    // float[] scale = new float[9] {13.63f, 0.38f, 0.95f, 1f, 0.53f, 11.21f, 9.45f, 4.01f, 3.88f};
    // float[] scale = new float[9] {1f, 0.38f, 0.95f, 1f, 0.53f, 11.21f, 9.45f, 4.01f, 3.88f};
    // float[] positionX = new float[9] {0f, 7.24f, 13.53f, 18.7f, 28.49f, 97.33f, 179.19f, 359.06f, 561.89f};
    float[] scale = new float[9] {2f, 0.038f, 0.095f, 0.1f, 0.053f, 1.121f, 0.945f, 0.401f, 0.388f};
    //Наклон оси вращения
    byte[] axialTilt = new byte[9] {7, 0, 177, 23, 25, 3, 27, 98, 28};
    float[] rotationSpeed = new float[9] {1f, 2f, 3f, 4f, 5f, 6f, 7f, 8f, 9f};

    void Start()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].transform.localScale = Vector3.one * scale[i];
            objects[i].transform.localRotation = Quaternion.Euler(axialTilt[i], 0, 0);
        }
    }

    void Update()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            //вращение вокруг своей оси
            objects[i].transform.Rotate (Vector3.up, rotationSpeed[i] * Time.deltaTime); 
        }
    }
}
