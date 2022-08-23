
using UnityEngine;

public class colorlerp : MonoBehaviour
{
    MeshRenderer SphereMeshRenderer;
    [SerializeField][Range(0f, 2f)] float lerpTime;
    [SerializeField] Color[] MaterialmyColors;

    int colorIndex = 0;
    //float t = 0;
    //int len;
    

    void Start()
    {
         SphereMeshRenderer = GetComponent<MeshRenderer>();
         //len= MaterialmyColors.Length;
    }

  
    void Update()
    {
        while (colorIndex < MaterialmyColors.Length)
        {
            SphereMeshRenderer.material.color = Color.Lerp(SphereMeshRenderer.material.color, MaterialmyColors[colorIndex], lerpTime * Time.deltaTime);
            colorIndex++;
        }
        
        //t = Mathf. Lerp (t, lerpTime , Time.deltaTime);
        //if(t > .9f)
        //{
        //    t = 0f;
        //    colorIndex++;
        //    colorIndex = (colorIndex>=len) ? colorIndex : 0;
        //}
    }
}
