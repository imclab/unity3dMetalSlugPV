using UnityEngine;
using System.Collections;

//玩家选择角色脚本
public class StartSelectCharacter : MonoBehaviour
{

    // Use this for initialization
    public GameObject[] SelectList;
    bool selected = false;//是否已经按下选择键选择角色
    int maxCharacter = 4;
    int selectIndex = -1;
    KeyBit keyBit = KeyBit.Instance;//按键实例
    PlayerData playerData = PlayerData.Instance;//玩家数据实例
    CharacterType[] arrCharacterType=new CharacterType[]{CharacterType.Marco,CharacterType.Eri,CharacterType.Tarma,CharacterType.Fio};//初始化角色
    void Start()
    {
        maxCharacter = SelectList.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (selectIndex == -1)//如果没有选中的话
        {
            selectIndex = 0;
            SelectList[selectIndex].SetActive(true);
        }
        if (Input.GetKeyDown(keyBit.shoot))//按下选中角色键（射击键）
        {
            selected = true;
            playerData.character = arrCharacterType[selectIndex];
            Debug.Log(playerData.character);
        }
        if (selected == false)
        {
            if (Input.GetKeyDown(keyBit.right))
            {
                SelectList[selectIndex].SetActive(false);
                selectIndex++;
                SetSelect();
            }
            else if (Input.GetKeyDown(keyBit.left))
            {
                SelectList[selectIndex].SetActive(false);
                selectIndex--;
                SetSelect();
            }
        }
    }
    void SetSelect()
    {
        selectIndex = selectIndex % maxCharacter;
        if (selectIndex < 0) selectIndex = maxCharacter - 1;//如果选择的索引小于0就让他选择最大角色数
        SelectList[selectIndex].SetActive(true);
    }
}
