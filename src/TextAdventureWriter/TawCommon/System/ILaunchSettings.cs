namespace SloanKellyGames.TawCommon.System
{
    public interface ILaunchSettings
    {
        string LanguageSpec { get; }

        string Lexicon { get; }

        string EntryPoint { get; }
    }
}
