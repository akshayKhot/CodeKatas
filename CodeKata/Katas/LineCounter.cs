using System;
using System.IO;
using System.Linq;

namespace CodeKata.Katas
{
    public class LineCounter
    {
        public int CountLinesOfCode(string filePath)
        {
            var count = 0;
            var lines = File.ReadAllLines(filePath);

            var inBlockComment = false;
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();

                if (trimmedLine.StartsWith("/*"))
                    inBlockComment = true;
                else
                    if (trimmedLine.Contains("*/"))                    
                        inBlockComment = false;
                    else
                        if (!inBlockComment && IsCode(trimmedLine))
                            count++;            
            }

            return count;
        }

        private static bool IsCode(string line)
        {
            var inValidLine = string.IsNullOrWhiteSpace(line) || line.StartsWith("//");

            return !inValidLine;
        }
    }
}