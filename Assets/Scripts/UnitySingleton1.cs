using UnityEngine;
using System.Collections;
public class UnitySingleton1 : MonoBehaviour
{

    private static UnitySingleton1 instance = null;
    public static UnitySingleton1 Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // any other methods you need

}