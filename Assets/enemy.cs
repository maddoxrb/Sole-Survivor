using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    public float speed = 3.5f;
    private Transform player;
    private NavMeshAgent agent;

    void Start()
    {
        // Find player by tag
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }

        // Get NavMeshAgent component
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = speed;
        }
    }

    void Update()
    {
        if (player != null && agent != null)
        {
            agent.SetDestination(player.position);
        }
    }
}