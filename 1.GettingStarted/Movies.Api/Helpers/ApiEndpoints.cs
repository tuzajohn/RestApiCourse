﻿namespace Movies.Api.Helpers
{
    public static class ApiEndpoints
    {
        private const string ApiBase = "api";

        public static class Movies
        {
            public const string Base = $"{ApiBase}/movies";
            public const string GetAll = Base;
            public const string Create = $"{Base}";
            public const string Get = $"{Base}/{{id}}";
            public const string Update = $"{Base}/{{id}}";
            public const string Delete = $"{Base}/{{id}}";
        }
    }
}
