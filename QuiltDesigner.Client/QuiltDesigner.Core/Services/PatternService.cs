using System.Collections.Generic;
using QuiltDesigner.Shared.Models;

namespace QuiltDesigner.Core.Services
{
    // PatternService handles quilt patterns
    public class PatternService
    {
        private readonly List<Pattern> _patterns = new List<Pattern>();

        // Get all patterns
        public List<Pattern> GetAllPatterns()
        {
            return _patterns;
        }

        // Add a new pattern
        public void AddPattern(Pattern pattern)
        {
            _patterns.Add(pattern);
        }

        // Generate a blank pattern with blocks
        public Pattern GenerateBlankPattern(string name, int width, int height)
        {
            var pattern = new Pattern
            {
                Name = name,
                Width = width,
                Height = height
            };

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    pattern.Blocks.Add(new Block
                    {
                        X = x,
                        Y = y,
                        Type = BlockType.Square // default type
                    });
                }
            }

            _patterns.Add(pattern);
            return pattern;
        }
    }
}
