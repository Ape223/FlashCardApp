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
        public DateTime DateReview { get;set; }
        /// <summary>
        /// Number of times the flashcard has been seen 
        /// </summary>
        [JsonPropertyName("reps")]
        public int reps { get; set; }
        /// <summary>
        /// EF of the flashcard
        /// </summary>
        public double ease { get; set; }
        public Flashcard(string term, string definition, DateTime dateReview)
        {
            Term = term;
            Definition = definition;
            DateReview = dateReview;
            reps = 0;
            ease = 1.3;
        }

        public override string ToString()
        {
            return $"{Term}:{Definition}";
        }
        //This is the SM2 algorithm
        public void SM2(Flashcard card, int quality)
        {
            if (0 < quality && quality < 5)
            {
                card.ease = BiggerOf(1.3, card.ease + 0.1 - (5.0 - quality) * (0.08 + (5.0 + quality) * 0.02));
                if (quality < 3)
                {
                    card.reps = 0;
                }
                else
                {
                    card.reps += 1;
                }
                if (card.reps <= 1)
                {
                    //adds 1 to the day of next review
                    card.DateReview = card.DateReview.AddDays(1);
                }
                else if (card.reps == 2)
                {
                    card.DateReview = card.DateReview.AddDays(6);
                }
                else
                {
                    card.DateReview = card.DateReview.AddDays(Diff(DateTime.Now, DateReview) * ease);
                }

            }

        }
        private double Diff(DateTime now, DateTime future)
        {
            double diff = (future - now).TotalDays;
            return diff;
        }

        //This is the replacement for the max keyword
        private double BiggerOf(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
