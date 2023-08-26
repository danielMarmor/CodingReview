using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingReview
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        AllowMultiple = true)]
    internal class CodeReview : Attribute
    {
        public string ReviewerName { get; set; }
        public string ReviewDate { get; set; }
        public bool IsApproved { get; set; }

        public CodeReview(string reviewerName, string reviewDate, bool isApproved)
        {
            ReviewerName = reviewerName;
            ReviewDate = reviewDate;
            IsApproved = isApproved;
        }

        public override string ToString()
        {
            return $"ReviewerName={ReviewerName},ReviewDate={ReviewDate}, IsApproved={IsApproved}";
        }


    }
}
