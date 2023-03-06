namespace D_D_Character_Creator.Data.Common
{
    public interface IMatchable
    {
        bool Matches(string text, bool nameOnly);
    }
}