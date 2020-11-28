using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceLucky : MonoBehaviour
{
    public int value = 6;
    public int iterations = 10;
    public float iterationDelay = 0.2f;
    public Transform[] faces;
    public bool isRolling;

    public IEnumerator Roll()
    {
        int randomValue = value;
        isRolling = true;
        for (int i = 0; i < iterations; i++)
        {
            while (randomValue == value)
                randomValue = Random.Range(1, 7);
            value = Random.Range(1, 7);
            for (int j = 0; j < 6; j++)
            {
                if (j + 1 == value)
                {
                    faces[j].gameObject.SetActive(true);
                }
                else
                {
                    faces[j].gameObject.SetActive(false);
                }
            }
            yield return new WaitForSeconds(iterationDelay);
        }
        isRolling = false;
    }
}
