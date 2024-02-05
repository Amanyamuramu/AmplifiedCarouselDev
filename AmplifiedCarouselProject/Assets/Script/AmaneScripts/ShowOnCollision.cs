using UnityEngine;

public class ShowOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 床と接触した場合にオブジェクトを表示
        if (other.CompareTag("Floor"))
        {
            GetComponent<MeshRenderer>().enabled = true;
            // GetComponent<SkinnedMeshRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // 床との接触が終了した場合にオブジェクトを非表示
        if (other.CompareTag("Floor"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            // GetComponent<SkinnedMeshRenderer>().enabled = false;
        }
    }
}
