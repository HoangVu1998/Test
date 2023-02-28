using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    public Vector3 center;
    public float speed = 10f;
    private int rotateCount = 0;
    private int maxRotateCount = 720;
    private bool rotateRight = true;

    void Update()
    {
        if (rotateCount < maxRotateCount)
        {
            transform.RotateAround(center, Vector3.forward, speed * Time.deltaTime * (rotateRight ? 1 : -1));
        }
        else
        {
            rotateCount = 0;
            rotateRight = !rotateRight;
        }
        rotateCount++;
        Instantiate(transform,Quaternion)
    }
    
}
