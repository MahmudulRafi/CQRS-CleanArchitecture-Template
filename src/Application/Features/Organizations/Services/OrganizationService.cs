﻿using Domain.Abstractions.Common;
using Domain.Entities;
using Domain.Models.Requests;
using Domain.Models.Responses;

namespace Application.Features.Organizations.Services
{
    public class OrganizationService(IUnitOfWork unitOfWork) : IOrganizationService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<bool> CreateOrganizationAsync(Organization organization, CancellationToken cancellationToken = default)
        {
            await _unitOfWork.Organizations.AddAsync(organization, cancellationToken);

            return await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Organization> GetOrganizationByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Organizations.GetByIdAsync(id, cancellationToken);
        }

        public async Task<List<Organization>> GetOrganizationsAsync(CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Organizations.GetItemsAsync(cancellationToken);
        }

        public async Task<PaginatedResponse<List<Organization>>> GetOrganizationsAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default)
        {
            var filtedRequest = new QueryableRequest<Organization>()
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                Includes = [],
                OrderBy = o => o.OrderBy(org => org.Name)
            };

            return await _unitOfWork.Organizations.GetItemsAsync(filtedRequest, cancellationToken);
        }

        public async Task<bool> OrganizationNameExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _unitOfWork.Organizations.EntryExists(a => a.Name == name, cancellationToken);
        }
    }
}
