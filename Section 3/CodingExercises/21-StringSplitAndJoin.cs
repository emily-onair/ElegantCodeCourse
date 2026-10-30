using System;

namespace Coding.Exercise
{
    public static class StringsTransformator
    {
        public static string TransformSeparators(
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            var list = input.Split(originalSeparator);
            return string.Join(targetSeparator, list);
        }
    }
}
