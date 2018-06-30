using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AstralProject.Models.TestClasses
{
    public class Note
    {
		static int i = 0;
		public static List<Note> GlobalNotes { get; set; }
		public string Base64Icon { get; set; }
		public int IdNote { get; set; }
		public string NoteName { get; set; }
		public string HeaderNote { get; set; }
		public string TextNote { get; set; }
		public DateTime DateNote { get; set; }
	    static Note()
		{
			GlobalNotes = new List<Note>();
		}
		public Note(string noteName,string headerNote,string textNote)
		{
			i++;
			IdNote = i;
			NoteName = noteName;
			HeaderNote = headerNote;
			TextNote = textNote;
			DateNote = DateTime.Now;
			Base64Icon = AddIcon(IdNote);
		}

		string AddIcon(int idNote)
		{
			string imgInString64 = "";
			using (var client = new HttpClient())
			{
				using (var response = client.GetStreamAsync($"https://avatars.dicebear.com/v2/identicon/{idNote}.svg").Result)
				{
					//byte[] byteArray = new byte[response.Length];
					//response.ReadAsync(byteArray, 0, (int)response.Length);
					//int count = 0;
					//while (count < response.Length)
					//{
					//	byteArray[count++] = Convert.ToByte(response.ReadByte());
					//}
					//imgInString64 = Convert.ToBase64String(byteArray);
					using (var streamReader = new  StreamReader(response,Encoding.UTF32))
					{
						
					}
				}
			}
			return imgInString64;

		}

	}
}
