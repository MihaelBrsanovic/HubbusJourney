using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempScript : MonoBehaviour
{
    public GameObject hobus;
    public Rigidbody2D rigid;
    private void Start()
    {
        hobus = GameObject.Find("Hobus");
        rigid = GetComponent<Rigidbody2D>();
        //rigid.velocity = new Vector2(Random.Range(-3, 3), Random.Range(-3, 3));
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = (hobus.transform.position - this.transform.position) * 2 / (hobus.transform.position - this.transform.position).magnitude;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") collision.gameObject.GetComponent<MainPlayerScript>().TakeDamage(50);
        Instantiate(this, new Vector3(0, 5), Quaternion.identity);
        Instantiate(this, new Vector3(0, 0), Quaternion.identity);
        Instantiate(this, new Vector3(0, -5), Quaternion.identity);
        Destroy(this.gameObject);
    }
}
