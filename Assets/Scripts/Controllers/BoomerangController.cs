using System.Collections.Generic;
using UnityEngine;

public class BoomerangController : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private SpriteRenderer spriteRenderer;    
    [SerializeField] private List<SOBoomerang> boomerangsConfigs;

    //private
    private int boomerangConfigIndex;


    // Start is called before the first frame update
    void Start()
    {
        boomerangConfigIndex = Random.Range(0, boomerangsConfigs.Count);                      

        spriteRenderer.sprite = boomerangsConfigs[boomerangConfigIndex].sprite;        
    }
        
}
