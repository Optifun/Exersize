using Infrastructure;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class EntryPoint : MonoBehaviour
{

	private void Awake ()
	{
		
	}
	// Start is called before the first frame update
	private void Start()
    private static void RegisterServices()
    {
        AllServices.Instance.RegisterSingle(new A3());
        AllServices.Instance.RegisterSingle(new B3());
    }

    /// <summary>
    /// Для того, чтобы гарантировать, что в программе есть только 1 инстанс класса
    /// мы используем такие техники
    /// </summary>
    private static void ActServices()
    {
        // Singleton - отстой
        A1.Instance.Act();
        A2.Instance.Act();
        
        
        // Multiton - лучше, но никуда не годится
        Globals.A.Act();
        Globals.B.Act2();
        
        // Service locator - более гибкий, не лишен прежней проблемы
        var a3 = AllServices.Instance.Single<A3>();
        var b3 = AllServices.Instance.Single<B3>();
        
        a3.Act();
        b3.Act2();
        
        // самый лаконичный способ - использовать DI
    }
}
}