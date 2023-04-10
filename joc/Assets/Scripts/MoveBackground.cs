using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private GameObject background1;
    [SerializeField]
    private GameObject background2;
    [SerializeField]
    private float speed;

    private Vector3 originalPosition1;
    private Vector3 originalPosition2;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition1 = background1.transform.position;
        originalPosition2 = background2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        background1.transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;
        background2.transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;

        if(background2.transform.position.x <= originalPosition1.x)
        {
             background1.transform.position = originalPosition1;
             background2.transform.position = originalPosition2;
        }
    }
}
