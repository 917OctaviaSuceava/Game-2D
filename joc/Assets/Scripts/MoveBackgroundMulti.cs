using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgroundMulti : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject background1;
    [SerializeField]
    private GameObject background2;
    [SerializeField]
    private GameObject background3;
    
    [SerializeField]
    private float speed;


    private Vector3 originalPosition;
    private Vector3 originalPosition1;
    private Vector3 originalPosition2;
    private Vector3 originalPosition3;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = background.transform.position;
        originalPosition1 = background1.transform.position;
        originalPosition2 = background2.transform.position;
        originalPosition3 = background3.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        background.transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;
        background1.transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;

        background2.transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;
        background3.transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;

        if(background1.transform.position.x <= originalPosition1.x && background3.transform.position.x <= originalPosition1.x)
        {
             background.transform.position = originalPosition;
             background1.transform.position = originalPosition1;
             background2.transform.position = originalPosition2;
             background3.transform.position = originalPosition3;
        }
    }
}
