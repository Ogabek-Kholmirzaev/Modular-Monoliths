﻿global using Shared.DDD;
global using System.Reflection;
global using Basket.Basket.Models;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Basket.Data;
global using Basket.Basket.Dtos;
global using FluentValidation;
global using Shared.Contracts.CQRS;
global using Basket.Basket.Exceptions;
global using Shared.Exceptions;
global using Mapster;
global using Carter;
global using MediatR;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Routing;
global using Microsoft.AspNetCore.Mvc;
global using Basket.Data.Repository;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using Basket.Data.JsonConverters;
global using Microsoft.Extensions.Caching.Distributed;
global using Catalog.Contracts.Products.Features.GetProductById;
global using MassTransit;
global using Microsoft.Extensions.Logging;
global using Shared.Messaging.Events;
global using Basket.Basket.Features.UpdateItemPriceInBasket;
global using System.Security.Claims;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;