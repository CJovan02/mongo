﻿using MongoDB.Bson;

namespace EMerx_backend.Result;

public static class ProductErrors
{
    public static Error NotFound(ObjectId id) => new(StatusCodes.NotFound, $"Product with id {id} not found.");
}