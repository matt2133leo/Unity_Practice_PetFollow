using UnityEngine;

public class Dragon : MonoBehaviour
{

    [Header("玩家位置")]
    private Transform player;
    

    [Range(0f,100f)]
    public float speed = 10f;

    private void Start()
    {
        player = GameObject.Find("private target").transform;
    }

    private void LateUpdate()
    {
        Pet_track();
    }

    /// <summary>
    /// 龍龍追蹤方法
    /// </summary>
    private void Pet_track()
    {
        Vector3 posPet = transform.position;
        Vector3 posplayer = player.position;

        transform.position = Vector3.Lerp(posPet , posplayer, 0.05f * Time.deltaTime * speed);
        transform.LookAt(posplayer);

    }


}
