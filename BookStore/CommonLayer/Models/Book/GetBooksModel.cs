﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.Models.Book
{
    public class GetBooksModel
    {
        //public int UserId { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int DiscountPrice { get; set; }
        public int OriginalPrice { get; set; }
        public string BookDescription { get; set; }
        public float Rating { get; set; }
        public int Reviewer { get; set; }
        public string Image { get; set; }
        public int BookCount { get; set; }
    }
}
