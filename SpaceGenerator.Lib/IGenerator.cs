using System.Drawing;

namespace SpaceGenerator.Lib
{
    public interface IGenerator
    {
        Bitmap Generate(GeneratorConfig generatorConfig);
    }
}