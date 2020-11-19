using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmaeraController : MonoBehaviour
{
    public Transform cam;
    public Transform player;
    public int[] camClampx;

    private void Update()
    {
        float x = Mathf.Clamp(player.position.x, camClampx[0], camClampx[1]);

        cam.position = new Vector3(x, cam.position.y, -1f);
    }

}
