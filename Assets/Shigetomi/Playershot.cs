using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playershot : MonoBehaviour
{
    public GameObject prefabSoccer_ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Attack()
    {
        Instantiate(prefabSoccer_ball);
    }

}
