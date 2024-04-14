using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScript : MonoBehaviour
{
    private GameObject rangeObject;
    public LayerMask playerLayerMask;
    public float playerCheckRadius = 0;


    private void Awake()
    {
        rangeObject = gameObject.transform.FindChild("RangeObject").gameObject;
        if (rangeObject == null)
        {
            Debug.LogError("RangeObject not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        List<Collider2D> results = new List<Collider2D>();
        ContactFilter2D filter = new ContactFilter2D().NoFilter();
        // One that is the characters itself
        if (Physics2D.OverlapCollider(rangeObject.GetComponent<BoxCollider2D>(), filter, results) > 1)
        {
            if(results.Find(obj => obj.name == "Player") != null)
            {
                // handle stop warning and avoid getting cheat again.
            }
        };
    }
}
