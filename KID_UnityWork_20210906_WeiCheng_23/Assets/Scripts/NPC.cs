using UnityEngine;

public class NPC : MonoBehaviour
///<summary>

///</summary>
{
    private int missionNumber;   

    /// <summary>
    /// ��ܤ��e
    /// </summary>
    /// <param name="content">NPC�n������ܤ��e</param>
    private void content(string content)
    {
        
    }
    /// <summary>
    /// �}�_�Ұө�
    /// </summary>
    /// <returns>�O</returns>
    public bool openStore()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price">�D��w�]����100</param>
    /// <returns>�Ǧ^0</returns>
    public int buyItem(int price = 100)
    {
        return 0;
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="missionNumber">���Ƚs��</param>
    public void getMission(int missionNumber)
    {
        
    }
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="getMissionItemNumber">��o���ȹD�㬰1</param>
    /// <returns>�Ǧ^0</returns>
    private int missionUpdate(int getMissionItemNumber = 1 )
    {
        return 0;
    }
    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="missionNumber">���Ƚs��</param>
    /// <returns>�Ǧ^�_</returns>
    private bool missionSuccessful(int missionNumber)
    {
        return false;
    }
}
