package balazs.bence.weatherapp

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.ListView
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class ForecastActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_forecast)

        var listView = findViewById<ListView>(R.id.forecastListView)

        var randomThings = listOf<String>("some wheather thing", "some wheather thing", "some wheather thing", "some wheather thing", "some wheather thing", "some wheather thing")

        var adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, randomThings)

        listView.adapter = adapter



        var retriever = WeatherRetriever()

        val callback = object : Callback<List<Forecast>> {

            override fun onResponse(call: Call<List<Forecast>>?, response: Response<List<Forecast>>?) {
                println("We got a response")
                println(response?.body())
            }

            override fun onFailure(call: Call<List<Forecast>>?, t: Throwable?) {
                println("We failed to get a response")
            }


        }

        retriever.getForecast(callback)
    }
}
