using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject cloudParticle;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Bird" || (other.contacts[0].normal.y<-0.5 && other.gameObject.tag=="Crate"))
        {
            Destroy(gameObject);
            Destroy(Instantiate(cloudParticle,new Vector3(gameObject.transform.position.x-0.5f,gameObject.transform.position.y-0.5f,0),Quaternion.identity),1f);
        }
    }
}
