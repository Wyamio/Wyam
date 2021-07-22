using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Wyam.Common.IO;

namespace Wyam.Images.Operations
{
    internal class OutputAction
    {
        private readonly Action<SixLabors.ImageSharp.Image, Stream> _action;
        private readonly Func<FilePath, FilePath> _pathModifier;

        public OutputAction(
            Action<SixLabors.ImageSharp.Image, Stream> action,
            Func<FilePath, FilePath> pathModifier)
        {
            _action = action;
            _pathModifier = pathModifier;
        }

        public void Invoke(SixLabors.ImageSharp.Image image, Stream stream) =>
            _action?.Invoke(image, stream);

        public FilePath GetPath(FilePath path) =>
            _pathModifier == null ? path : _pathModifier(path);
    }
}
