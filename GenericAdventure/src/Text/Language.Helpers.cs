using System.Text;

namespace GenericAdventure.Text;

public partial class Language
{
    private readonly StringBuilder _stringBuilder = new();

    public virtual string JoinedWordList(string[] words, string conjunction)
    {
        _stringBuilder.Clear();

        for (var i = 0; i < words.Length; i++)
        {
            if (i > 0)
            {
                _stringBuilder.Append(words.Length > 2 ? Comma + Space : Space);
            }

            if (i == words.Length - 1 && words.Length > 1)
            {
                _stringBuilder.Append(conjunction + Space);
            }

            _stringBuilder.Append(words[i]);
        }

        return _stringBuilder.ToString();
    }
}