using Vector;
using Primitives;

namespace Parser
{
	static public class OBJParser
	{
		static string ReadFile()
		{
			try { return (new StreamReader("/home/eraz/Documents/Alexander/Perso/Project/OBJ_files/Crate1.obj").ReadToEnd()); }
			catch (Exception e)
			{
				Console.WriteLine("Cannot reat from file.");
				Console.WriteLine("Error: {0}", e);

				return ("");
			}
		}
		
		static private Mesh GetMesh(List<string> lines, List<Vector_3D> vertices)
		{
			void AddVertexToPolygone(string string_vertex_index, Polygone_3D polygone)
			{
				int numerical_vertex_index;

				if (Int32.TryParse(string_vertex_index, out numerical_vertex_index) && numerical_vertex_index <= vertices.Count)
					polygone.coord.Add(vertices[numerical_vertex_index]);
			}

			Polygone_3D ParsePolygoneLine(string line, List<Vector_3D> vertices)
			{
				Polygone_3D result = new Polygone_3D();

				string[] polygones_indexes = line.Substring(2).Split(' ');

				foreach (string polygone_indexes in polygones_indexes)
				{
					string[] separated_polygone_indexes = polygone_indexes.Split('/');

					if (separated_polygone_indexes.Length > 0) AddVertexToPolygone(separated_polygone_indexes[0], result);
					//if (separated_polygon	e_indexes.Length > 1)
					//if (separated_polygone_indexes.Length > 2)
				}

				return (result);
			}

			Mesh result = new Mesh();

			foreach (string line in lines)
			{
				if (line.StartsWith("f "))
					result.polygones.Add(ParsePolygoneLine(line, vertices));
			}

			return (result);
		}
		
		static private List<Vector_3D> GetVertices(List<string> lines)
		{
			Vector_3D ParseVertexLine(string line)
			{
				Vector_3D result = new Vector_3D();
				
				string[] vertex_coord = line.Substring(2).Split(' ');

				if (vertex_coord.Length == 3)
				{
					float.TryParse(vertex_coord[0], out result.x);
					float.TryParse(vertex_coord[1], out result.y);
					float.TryParse(vertex_coord[2], out result.z);
				}

				return (result);
			} 

			List<Vector_3D> result = new List<Vector_3D>();

			foreach (string line in lines)
			{
				if (line.StartsWith("v "))
					result.Add(ParseVertexLine(line));
			}

			return (result);
		} 

		static Mesh ParseFile(string file_content)
		{
			List<string> file_lines  = file_content.Split('\n').ToList();
			List<Vector_3D> vertices = GetVertices(file_lines);

			return (GetMesh(file_lines, vertices));
		}
	}
}