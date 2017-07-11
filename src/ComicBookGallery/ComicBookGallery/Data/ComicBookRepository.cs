using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "Final issue!",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"  },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"  },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"  },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"  },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"  }
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<strong>The Dungeon & The Parapet</strong>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script"},
                    new Artist() { Name = "Jeff Smith", Role = "Pencils"},
                    new Artist() { Name = "Jeff Smith", Role = "Inks"},
                    new Artist() { Name = "Jeff Smith", Role = "Letters"}
                },
                Favorite = false
            }
    };
        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }
        public ComicBook GetComicBook( int id)

        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }

            return comicBookToReturn;
        }
    }
}