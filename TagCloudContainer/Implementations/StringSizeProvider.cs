using System.Drawing;
using TagCloudContainer.Api;
using TagCloudContainer.ResultMonad;

namespace TagCloudContainer.Implementations
{
    [CliElement("realsize")]
    public class StringSizeProvider : IStringSizeProvider
    {
        public static Graphics GraphicsBase = Graphics.FromImage(new Bitmap(1, 1));
        public Font Font;

        public StringSizeProvider(Font font)
        {
            Font = font;
        }

        public Result<Size> GetStringSize(string word, int occurrenceCount)
        {
            var size = GraphicsBase.MeasureString(word, Font).ToSize();
            return new Size((int) (size.Width * 1.05f), (int) (size.Height / 1.2f));
        }
    }
}