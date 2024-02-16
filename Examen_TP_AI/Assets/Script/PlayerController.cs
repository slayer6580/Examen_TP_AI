using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private NavMeshAgent m_navMeshAgent;

    void Start()
    {
        m_navMeshAgent = GetComponent<NavMeshAgent>();

        if (m_navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent non trouvé sur le GameObject.");
        }
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                m_navMeshAgent.SetDestination(hit.point);
            }
        }
    }
}
