using System;

namespace WebToAppConverter.Services {
    public class UrlValidatorService {
        public bool IsValidUrl(string url) {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}