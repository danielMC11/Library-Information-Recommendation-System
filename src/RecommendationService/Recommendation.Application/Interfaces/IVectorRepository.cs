using Recommendation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recommendation.Application.Interfaces;


public  interface IVectorRepository
{    

    Task SaveBatchAsync(IEnumerable<BookVectorRecord> records);

}
