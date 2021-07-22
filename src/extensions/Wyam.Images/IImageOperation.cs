using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Wyam.Common.IO;

namespace Wyam.Images.Operations
{
    internal interface IImageOperation
    {
        IImageProcessingContext Apply(IImageProcessingContext image);
        FilePath GetPath(FilePath path);
    }
}
