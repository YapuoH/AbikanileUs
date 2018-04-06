using UnityEngine;

public class bulletMov : MonoBehaviour {

    public float speed;

    void Start () {

        Destroy(gameObject, 1.5f);

    }

    void Update () {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
