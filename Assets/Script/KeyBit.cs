using UnityEngine;
using System.Collections;
//保存玩家键位的数据-单列模式
public class KeyBit  {
    public static KeyBit Instance
    {
        get
        {
             if(instance==null)
             {
                 instance = new KeyBit();
             }
             return instance;
        }
    }
    private static KeyBit instance;
    public KeyCode shoot;//射击键
    public KeyCode jump;
    public KeyCode bomb;
    public KeyCode up,down,left,right;//上下左右
    private KeyBit()
    {
        //初始化按键
        up = KeyCode.W;
        down = KeyCode.S;
        left = KeyCode.A;
        right = KeyCode.D;
        shoot = KeyCode.J;
        jump = KeyCode.K;
        bomb = KeyCode.L;
    }
}
