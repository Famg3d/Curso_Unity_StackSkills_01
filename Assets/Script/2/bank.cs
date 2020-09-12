using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bank 
{
    public string branchName;
    public string location;
    public string cashInVault;

    public void CheckBalance()
    {
        Debug.Log("CheckingBalance: " + branchName);
    }
    public void Withdawl()
    {
        Debug.Log("Withdrawling Money from: " + branchName);
    }
    public void Deposit()
    {
        Debug.Log("Depositing money to: " + branchName);
    }
}
