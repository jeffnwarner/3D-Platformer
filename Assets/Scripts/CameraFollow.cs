using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public float DistanceFromPlayer = 5f;
    public float StaticCameraY = 3f;
    public float DistanceInFrontOfPlayer = 4f;

    void Start() {
        Vector3 temp = transform.position;
        temp.y = StaticCameraY;
        Camera.main.transform.position = temp;
    }

    void Update() {
        Vector3 temp = transform.position;
        temp.z = Player.position.z - DistanceFromPlayer;
        temp.x = Player.position.x + DistanceInFrontOfPlayer;
        transform.position = temp;
    }
}
