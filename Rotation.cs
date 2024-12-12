using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject obj;
    public int rotateSpeed;

    [Header("Axis")]
    public bool XAxis;
    public bool YAxis;
    public bool ZAxis;

    void Update()
    {
        if (XAxis == true)
        obj.transform.Rotate(rotateSpeed, 0, 0 * Time.deltaTime);

        if (YAxis == true)
        {
            obj.transform.Rotate(0, rotateSpeed, 0 * Time.deltaTime);
        }

        if (ZAxis == true)
        {
            obj.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }
    }
}
