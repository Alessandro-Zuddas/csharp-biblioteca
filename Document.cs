using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        string docCode;
        string docTitle;
        string docYear;
        string docCourse;
        string docLocation;
        string docAuthor;

        public Document(string docCode, string docTitle, string docYear, string docCourse, string docLocation, string docAuthor)
        {
            this.docCode = docCode;
            this.docTitle = docTitle;
            this.docYear = docYear;
            this.docCourse = docCourse;
            this.docLocation = docLocation;
            this.docAuthor = docAuthor;
        }

        public string getDocCode()
        {
            return this.docCode;
        }

        public string getDocTitle()
        {
            return this.docTitle;
        }

        public string getDocYear()
        {
            return this.docYear;
        }

        public string getDocCourse()
        {
            return this.docCourse;
        }

        public string getDocLocation()
        {
            return this.docLocation;
        }

        public string getDocAuthor()
        {
            return this.docAuthor;
        }
    }

    public class Book : Document
    {

        int bookPages;

        public Book(string docCode, string docTitle, string docYear, string docCourse, string docLocation, string docAuthor, int bookPages) : base(docCode, docTitle, docYear, docCourse, docLocation, docAuthor)
        {
            this.bookPages = bookPages;
        }

        public int getBookPages()
        {
            return this.bookPages;
        }
    }

    public class Dvd : Document
    {

        string duration;

        public Dvd(string docCode, string docTitle, string docYear, string docCourse, string docLocation, string docAuthor, string duration) : base(docCode, docTitle, docYear, docCourse, docLocation, docAuthor)
        {
            this.duration = duration;
        }

        public string getDuration()
        {
            return this.duration;
        }
    }
}
