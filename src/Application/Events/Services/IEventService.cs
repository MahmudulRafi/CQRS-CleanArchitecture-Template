﻿using Domain.Entities;

namespace Application.Events.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetEventsAsync(CancellationToken cancellationToken = default);
    }
}
