using UnityEngine;

public class NPC : MonoBehaviour
///<summary>

///</summary>
{
    private int missionNumber;   

    /// <summary>
    /// 對話內容
    /// </summary>
    /// <param name="content">NPC要說的對話內容</param>
    private void content(string content)
    {
        
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
    /// <param name="price">道具預設價格100</param>
    /// <returns>傳回0</returns>
    public int buyItem(int price = 100)
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="missionNumber">任務編號</param>
    public void getMission(int missionNumber)
    {
        
    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="getMissionItemNumber">獲得任務道具為1</param>
    /// <returns>傳回0</returns>
    private int missionUpdate(int getMissionItemNumber = 1 )
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
