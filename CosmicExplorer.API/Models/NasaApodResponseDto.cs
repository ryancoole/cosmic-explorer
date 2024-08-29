using Swashbuckle.AspNetCore.Annotations;

namespace CosmicExplorer.API.Models
{
    public class NasaApodResponseDto
    {
        [SwaggerSchema(Description = "The date of the APOD image")]
        public string Date { get; set; }

        [SwaggerSchema(Description = "Explanation of the APOD image")]
        public string Explanation { get; set; }

        [SwaggerSchema(Description = "URL of the high-definition version of the image")]
        public string Hdurl { get; set; }

        [SwaggerSchema(Description = "The media type, e.g., image or video")]
        public string MediaType { get; set; }

        [SwaggerSchema(Description = "Service version")]
        public string ServiceVersion { get; set; }

        [SwaggerSchema(Description = "Title of the APOD image")]
        public string Title { get; set; }

        [SwaggerSchema(Description = "URL of the image or video")]
        public string Url { get; set; }
    }
}