using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KevinsShop.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
