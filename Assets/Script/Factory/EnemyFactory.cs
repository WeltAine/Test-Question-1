using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : Factory
{

    public EnemyGroup prefab;
    public override IProduct Produce()
    {
        {
            //GameObject newEnemyGroup = new GameObject("EnemyGroup (Clone)", typeof(EnemyGroup));
            //newEnemyGroup.transform.position = this.transform.position;
            //newEnemyGroup.GetComponent<EnemyGroup>().row = (int)(Random.Range(2, 7));
            //return newEnemyGroup.GetComponent<EnemyGroup>();
        }

        EnemyGroup newEnemys = GameObject.Instantiate(prefab, this.transform);
        newEnemys.row = (int)(Random.Range(4, 10));
        return newEnemys;

    }

    IEnumerator AutoProduce()
    {

        while (true)
        {
            IProduct produce = this.Produce();
            produce.Work();
            yield return new WaitForSeconds(3.0f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(AutoProduce());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
