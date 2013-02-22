using System;
using System.IO;

namespace Euclidian3DSpace
{
    static class PathStorage
    {
        public static Path LoadPathFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            Path curentPath = new Path();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] temp = line.Split(' ');
                    Point3D point = new Point3D(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
                    curentPath.AddPointToPath(point);
                    
                    
                    line = reader.ReadLine();
                }
            }
            return curentPath;
        }
        public static void SavePathToFile(string file, Path path, bool appendFile)
        {
            StreamWriter writer = new StreamWriter(file, appendFile);

            using (writer)
            {
                foreach (var point in path.Points)
                {
                    writer.WriteLine(point);   
                }
            }
        }
    }
}
