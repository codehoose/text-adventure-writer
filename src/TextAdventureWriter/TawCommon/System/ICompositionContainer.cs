namespace SloanKellyGames.TawCommon.System
{
    public interface ICompositionContainer
    {
        T GetExportedValue<T>(string contractName = "");
    }
}
