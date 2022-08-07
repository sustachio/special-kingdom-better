using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipOnButtonPress : MonoBehaviour
{
    [SerializeField] KeyCode kSwapKey;

    // time left on movement
    float timeLeft = 0;
    // height at the start of movement
    float startHeight = 0;
    // distance to next platform
    float distance;

    // 1 is up -1 is down
    public float facing = 1;

    void Update()
    {
        // smoothly transition to the ceiling
        if (0 < timeLeft)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

            // https://www.desmos.com/calculator/4hoe7ucqgk
            float change = 1f/(1f+Mathf.Pow(2.718f, (-5.7f*((2*(1-timeLeft))-1))))*facing;

            // change height
            transform.position = new Vector3(transform.position.x, startHeight+(distance*change), transform.position.z);
            // change rotation
            transform.rotation = Quaternion.Euler(0, 0, (180f*-((facing-1)/2))+180f*change);

            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft < 0)
        {
            GetComponent<Rigidbody2D>().gravityScale *= -1;
            timeLeft = 0;

            // set rotation if change didn't get to exectly 1
            transform.rotation = Quaternion.Euler(0, 0, (180f * -((facing - 1) / 2) + 180f));

            facing *= -1;
        }
        if (Input.GetKeyDown(kSwapKey))
        {

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up*facing, 100.0f, LayerMask.GetMask("Ground"));

            if ((hit.collider != null) && !(0 < timeLeft))
            {
                distance = Mathf.Abs(hit.point.y - transform.position.y) -1.5f;
                timeLeft = 1f;
                startHeight = transform.position.y;
            }
        }
    }
}
