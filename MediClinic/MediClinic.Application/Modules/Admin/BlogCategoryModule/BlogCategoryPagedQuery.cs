﻿using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using MediClinic.Domain.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Admin.BlogCategoryModule
{
    public class BlogCategoryPagedQuery : IRequest<PagedViewModel<BlogCategory>>
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public class BlogCategoryPagedQueryHandler : IRequestHandler<BlogCategoryPagedQuery, PagedViewModel<BlogCategory>>
        {
            readonly MediClinicDbContext db;
            public BlogCategoryPagedQueryHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<PagedViewModel<BlogCategory>> Handle(BlogCategoryPagedQuery request, CancellationToken cancellationToken)
            {
                var model = db.BlogCategories.Where(s => s.DeletedByUserId == null).AsQueryable();

                return new PagedViewModel<BlogCategory>(model, request.PageIndex, request.PageSize);
            }
        }
    }
}
