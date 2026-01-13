# A small weather App in Blazor

This project is a sandbox for learning .NET, Blazor, xUnit.

It is using a free service (that allows a certain number of requests per month)



The public API is taken into use to getting geographical coordinates [https://openweathermap.org/api/geocoding-api](https://openweathermap.org/api/geocoding-api) that will later be passed into

for getting the weather.s


## Configuration

Before running this project, you **must** prepopulate the `appsettings.json` file with your correct data. The file requires the following variables:

```json
{
  "AppSettings": {
    "APIAccessKey": " "
  }
}
```

- **APIAccessKey**: make your own free of charge on [https://openweathermap.org/api/geocoding-api](https://openweathermap.org/api/geocoding-api).