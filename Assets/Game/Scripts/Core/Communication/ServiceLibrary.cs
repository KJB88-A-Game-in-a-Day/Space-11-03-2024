public static class ServiceLibrary
{
    private readonly static string messageBroker = "messageBroker";
    public static string MessageBroker => messageBroker.ToLower();

    private readonly static string gameManager = "gameManager";
    public static string GameManager => gameManager.ToLower();
    private readonly static string objectPool = "objectPool";
    public static string ObjectPool => objectPool.ToLower();
}