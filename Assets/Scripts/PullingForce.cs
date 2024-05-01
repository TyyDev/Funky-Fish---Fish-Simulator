using UnityEngine;

public class GravityAttractor : MonoBehaviour
{
    public float gravitationalForce = 100f;

    void Update()
    {
        AttractObjects();
    }

    void AttractObjects()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 200f); 

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("AttractedObject"))
            {
                Rigidbody rb = collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    Vector3 gravityUp = (collider.transform.position - transform.position).normalized;
                    Vector3 localUp = collider.transform.up;

                    rb.AddForce(gravityUp * gravitationalForce);

                    Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * collider.transform.rotation;
                    collider.transform.rotation = Quaternion.Slerp(collider.transform.rotation, targetRotation, 50f * Time.deltaTime);
                }
            }
        }
    }
}
