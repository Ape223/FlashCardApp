using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace FlashCardApp
{
    internal class Flashcard
    {
        /// <summary>
        /// The term of the flashcard.
        /// </summary>
        [JsonPropertyName("term")]
        public string Term { get;private set; }

        /// <summary>
        /// The definition of the flashcard.
        /// </summary>
        [JsonPropertyName("definition")]
        public string Definition { get;private set; }
        /// <summary>
        /// The date that the flashcard needs to be next reviewed
        /// </summary>
        [JsonPropertyName("dateReview")]
        public string DateReview { get;set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Flashcard(string term, string definition, string dateReview)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Term = term;
            Definition = definition;
#pragma warning disable CS8601 // Possible null reference assignment.
            DateReview = dateReview;
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        public override string ToString()
        {
            return $"{Term}:{Definition}";
        }
    }
}
