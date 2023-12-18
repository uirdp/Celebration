using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisionScript : MonoBehaviour
{

    [SerializeField] private EnemyController enemyController;

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
        enemyController.WakeUp();
    }

    private void OnTriggerExit(Collider other)
    {
        enemyController.DestroyEnemy();
    }
}
