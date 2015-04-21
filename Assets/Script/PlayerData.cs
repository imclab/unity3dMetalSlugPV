using UnityEngine;
using System.Collections;
//用于保存玩家的数据-单列模式
public enum CharacterType//角色类型-全局枚举
{
    Marco,Eri,Tarma,Fio
}
public class PlayerData  {

    public static PlayerData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerData();
            }
            return instance;
        }
    }
    private static PlayerData instance;
    public CharacterType character;//玩家选择的角色
}
