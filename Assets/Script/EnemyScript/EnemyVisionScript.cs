using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisionScript : MonoBehaviour
{

    [SerializeField] private EnemyController enemyController;
    public GameObject player;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Collider");
        if(other.gameObject.tag == "Player") enemyController.WakeUp();
    }

    private void OnTriggerExit(Collider other)
    {
        if(enemy.transform.position.x > player.transform.position.x) enemyController.DestroyEnemy();
    }
}
