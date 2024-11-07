﻿using MediatR;

namespace Evently.Modules.Events.Application.Events.CreateEvent;

public sealed record CreateEventCommand(
    string Title,
    string Description,
    string Location,
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc) : IRequest<Guid>;
