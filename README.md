# A small weather App in Blazor

This project is a sandbox for learning .NET, Blazor, bUnit.

It is using a free geolocation and weather service [https://openweathermap.org/api/geocoding-api](https://openweathermap.org/api/geocoding-api) that allows 1000 requests per day.



## Configuration

Before running this project, you **must** prepopulate the `appsettings.json` file with your correct AppId. You can generate AppId while registering a free plan on [https://openweathermap.org/api/geocoding-api](https://openweathermap.org/api/geocoding-api). The file requires the following variables:

```json
{
  "AppSettings": {
    "AppId": " "
  }
}
```