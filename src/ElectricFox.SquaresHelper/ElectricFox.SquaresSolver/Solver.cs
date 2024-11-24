using System.Drawing;

namespace ElectricFox.SquaresSolver
{
    public class Solver(char[,] letters)
    {
        private readonly HashSet<Point> usedPlaces = [];

        public bool IsValidWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word)) return false;

            foreach (var point in GetStartingPoints(word[0]))
            {
                usedPlaces.Clear();
                usedPlaces.Add(point);

                if (IsRestOfWordSolvable(word, 1, point))
                {
                    return true;
                }
            }

            return false;
        }

        private IEnumerable<Point> GetStartingPoints(char c)
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (letters[x, y] == c)
                    {
                        yield return new Point(x, y);
                    }
                }
            }
        }

        private bool IsRestOfWordSolvable(string word, int index, Point p)
        {
            var points = GetSurroundingPoints(p).Where(p1 => !usedPlaces.Contains(p1));

            foreach (var point in points)
            {
                if (letters[point.X, point.Y] == word[index])
                {
                    usedPlaces.Add(point);

                    if (index == word.Length - 1 || IsRestOfWordSolvable(word, index + 1, point))
                    {
                        return true;
                    }

                    usedPlaces.Remove(point);
                }
            }

            return false;
        }

        private static IEnumerable<Point> GetSurroundingPoints(Point p)
        {
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue;

                    int newX = p.X + dx;
                    int newY = p.Y + dy;

                    if (newX >= 0 && newX < 4 && newY >= 0 && newY < 4)
                    {
                        yield return new Point(newX, newY);
                    }
                }
            }
        }
    }
}
