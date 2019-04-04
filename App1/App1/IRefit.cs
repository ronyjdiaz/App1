using System;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Threading.Tasks;

namespace App1
{
    public interface IRefit
    {
        [Get("/posts")]
        Task<List<string>> GetPostAsync();
    }
}
