﻿namespace Notifications.Application.Common.Models.Abstractions;

public abstract class PaginationQuery
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? TextSearch { get; set; }
}