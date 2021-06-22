using System;
namespace InheritanceExample
{

    public enum PublicationType { Misc, Book, Magazine, Article };

    public abstract class Publication
    {

        private int totalPages;
        private DateTime datePublished;
        private bool published = false;

        public string Publisher { get; }
        public string Title { get; }
        public PublicationType Type { get; }
        public string CopyrightName { get; private set; }
        public int CopyrightDate { get; private set; }

        public int Pages { get
            {
                return totalPages;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The number of pages can't be zero or less than zero");
                totalPages = value;
            }
        }


        public Publication(string title, string publisher, PublicationType type)
        {
            if (String.IsNullOrWhiteSpace(publisher))
                throw new ArgumentException("The publisher is required");
            this.Publisher = publisher;
            if (String.IsNullOrWhiteSpace(title))
                throw new ArgumentException("The title is required");
            this.Title = title;
            this.Type = type;
        }

        public string GetPublicationDate()
        {
            if (!published)
                return "NYP";
            else
                return datePublished.ToString("d");
        }

        public void Publish(DateTime datePublished)
        {
            this.published = true;
            this.datePublished = datePublished;
        }

        public void Copyright(string copyrightName, int copyrightDate)
        {
            if (String.IsNullOrWhiteSpace(copyrightName))
                throw new ArgumentException("The name of the copyright holder is required.");
            this.CopyrightName = copyrightName;

            int currentYear = DateTime.Now.Year;
            if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
                throw new ArgumentException($"The copyright year must be between {currentYear - 10} and {currentYear + 1}");

            this.CopyrightDate = copyrightDate;

        }

        public override string ToString() => Title; 
    }
}
