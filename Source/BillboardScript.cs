//Fixed With [DOGE]DEN aottg Sources fixer
//Doge Guardians FTW
//DEN is OP as fuck.
//Farewell Cowboy

using UnityEngine;

public class BillboardScript : MonoBehaviour
{
    public void Main()
    {
    }

    public void Update()
    {
        base.transform.LookAt(Camera.main.transform.position);
        base.transform.Rotate((Vector3) (Vector3.left * -90f));
    }
}

