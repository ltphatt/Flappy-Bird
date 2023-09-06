using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] float speed = .65f;
    //[SerializeField] float speedAtMedium = 0.675f;
    //[SerializeField] float sppedAtHard = 0.7f;
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    //private void FixedUpdate()
    //{
    //    IncreaseSpeed();
    //}

    //public void IncreaseSpeed()
    //{
    //    int score = Score.instance.GetCurrentScore();
    //    if (score >= 10)
    //    {
    //        speed = speedAtMedium;
    //    }
    //    else if( score >= 15)
    //    {
    //        speed = sppedAtHard;
    //    }
    //}
}
