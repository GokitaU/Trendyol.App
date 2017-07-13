﻿using System;
using Trendyol.App.Domain.Abstractions;

namespace Trendyol.App.Domain.Objects.DateTimeProviders
{
    public class LocalDateTimeProvider : IDateTimeProvider
    {
        public DateTimeKind Kind => DateTimeKind.Local;
        public DateTime Now => DateTime.Now;
    }
}