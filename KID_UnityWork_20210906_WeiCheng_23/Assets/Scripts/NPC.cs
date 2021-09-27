using UnityEngine;

public class NPC : MonoBehaviour
///<summary>

///</summary>
{
    public int itemMoney = 100;
    public int missionNumber;
    public int getMissionItemNumber = 1;

    /// <summary>
    /// 對話內容
    /// </summary>
    private void content()
    {
        print("對話內容");
    }
    /// <summary>
    /// 開否啟商店
    /// </summary>
    /// <returns>是</returns>
    public bool openStore()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="itemMoney">道具預設價格100</param>
    /// <returns>傳回0</returns>
    public int buyItem(int itemMoney)
    {
        return int 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="missionNumber">任務編號</param>
    public void getMission(int missionNumber)
    {
        print("取得任務")
    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="getMissionItemNumber">獲得任務道具為1</param>
    /// <returns>傳回0</returns>
    private int missionUpdate(int getMissionItemNumber)
    {
        return 0;
    }
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <param name="missionNumber">任務編號</param>
    /// <returns>傳回否</returns>
    private bool missionSuccessful(int missionNumber)
    {
        return false;
    }
}
