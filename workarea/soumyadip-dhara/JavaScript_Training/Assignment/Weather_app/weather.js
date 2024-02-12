const apikey = "e9e8183b8456d65102879f668c62a371";
const apiurl = "https://api.openweathermap.org/data/2.5/weather?units=metric&q=";
const searchbox = document.querySelector(".search input");
const searchbtn = document.querySelector(".search button");
const weathericon = document.querySelector(".weather-icon");

async function checkweather(city) {
    const response = await fetch(apiurl + city + `&appid=${apikey}`);
    if (response.status == 404) {
        document.querySelector(".error").style.display = "block";
        document.querySelector(".weather").style.display = "none";
    }
    else {
        document.querySelector(".error").style.display = "none";
        var data = await response.json();

        document.querySelector(".city").innerHTML = data.name;
        document.querySelector(".temp").innerHTML = Math.round(data.main.temp) + "°C";
        document.querySelector(".humidity").innerHTML = data.main.humidity + "%";
        document.querySelector(".wind").innerHTML = data.wind.speed + "km/h";

        if (data.weather[0].main == "Clouds") {
            weathericon.src = "images/clouds.png";
        }
        else if (data.weather[0].main == "Clear") {
            weathericon.src = "images/clear.png";
        }
        else if (data.weather[0].main == "Snow") {
            weathericon.src = "images/snow.png";
        }
        else if (data.weather[0].main == "Rain") {
            weathericon.src = "images/rain.png";
        }
        else if (data.weather[0].main == "Drizzle") {
            weathericon.src = "images/drizzle.png";
        }
        else if (data.weather[0].main == "Mist") {
            weathericon.src = "images/mist.png";
        }

        document.querySelector(".weather").style.display = "block";
    }

}


searchbtn.addEventListener("click", () => {
    checkweather(searchbox.value);
})

searchbox.addEventListener("keydown", (event) => {
    if (event.key === "Enter") {
        checkweather(searchbox.value);
    }
});