using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
	class Program
	{
		static void Main(string[] args)
		{
			string wordPath = @"F:\workspacezwd\科研细则.docx"; //调出科研细则文档所在地址
			using (WordprocessingDocument mydoc = WordprocessingDocument.Open(wordPath, true))//创建一个新的类
			{
				Body abody = mydoc.MainDocumentPart.Document.Body;
				//创建Body类
				foreach (var paragraph in abody.Elements<Paragraph>())//将每一行的数据都访问一次
				{
					Console.WriteLine(paragraph.InnerText);//将对象打印出来
				}
			}
			Console.ReadLine();//显示
		}
	}
}
