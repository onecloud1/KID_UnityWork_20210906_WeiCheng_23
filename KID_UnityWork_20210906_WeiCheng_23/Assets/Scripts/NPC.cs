using UnityEngine;

public class NPC : MonoBehaviour
///<summary>

///</summary>
{
    public int itemMoney = 100;
    public int missionNumber;
    public int getMissionItemNumber = 1;

    /// <summary>
    /// ��ܤ��e
    /// </summary>
    private void content()
    {
        print("��ܤ��e");
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
    /// <param name="itemMoney">�D��w�]����100</param>
    /// <returns>�Ǧ^0</returns>
    public int buyItem(int itemMoney)
    {
        return int 0;
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="missionNumber">���Ƚs��</param>
    public void getMission(int missionNumber)
    {
        print("���o����")
    }
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="getMissionItemNumber">��o���ȹD�㬰1</param>
    /// <returns>�Ǧ^0</returns>
    private int missionUpdate(int getMissionItemNumber)
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
