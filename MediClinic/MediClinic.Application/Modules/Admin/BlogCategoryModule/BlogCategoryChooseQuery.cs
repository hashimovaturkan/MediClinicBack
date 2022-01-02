//using MediClinic.Domain.Models.DataContexts;
//using MediClinic.Domain.Models.Entities;
//using MediatR;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MediClinic.Application.Modules.Admin.BlogCategoryModule
//{
//    public class BlogCategoryChooseQuery : IRequest<List<BlogCategory>>
//    {
//        public class BlogCategoryChooseQueryHandler : IRequestHandler<BlogCategoryChooseQuery, List<BlogCategory>>
//        {
//            readonly MediClinicDbContext db;
//            public BlogCategoryChooseQueryHandler(MediClinicDbContext db)
//            {
//                this.db = db;
//            }

//            public async Task<List<BlogCategory>> Handle(BlogCategoryChooseQuery request, CancellationToken cancellationToken)
//            {
//                var categories = await db.BlogCategories
//                                    .Where(c => c.DeletedByUserId == null ).ToListAsync();
//                return categories;
//            }
//        }
//    }
//}
