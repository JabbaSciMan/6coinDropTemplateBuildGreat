using UnityEngine;

public class TargetedDestroy2D : MonoBehaviour
{
    [SerializeField] private GameObject objectToDestroy;

    private void OnMouseDown()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}
