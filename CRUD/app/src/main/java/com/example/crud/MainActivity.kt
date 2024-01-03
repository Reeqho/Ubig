package com.example.crud

import android.graphics.BitmapFactory
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.appcompat.view.menu.ActionMenuItemView
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import androidx.recyclerview.widget.RecyclerView.ViewHolder
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.GlobalScope
import kotlinx.coroutines.launch
import org.json.JSONArray
import org.json.JSONObject
import java.net.HttpURLConnection
import java.net.URL

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        var recyclerview = findViewById<RecyclerView>(R.id.user_rv)


        GlobalScope.launch (Dispatchers.IO){
            val url = URL("https://dummyapi.io/data/v1/user")
            val conn = url.openConnection() as HttpURLConnection
            conn.requestMethod = "GET"
            conn.setRequestProperty("app-id", "658b9f3b6ba9a41da4a153e5")

            val result = conn.inputStream.bufferedReader().readLine().toString()
            GlobalScope.launch (Dispatchers.Main){
                Log.d("CEK_DATA", result)
                val users = JSONObject(result).getJSONArray("data")

                recyclerview.adapter = UserAdapter(users)
                recyclerview.layoutManager = LinearLayoutManager(this@MainActivity, LinearLayoutManager.VERTICAL, true)

            }
        }
    }

    class UserAdapter(val users: JSONArray) : RecyclerView.Adapter<UserAdapter.UserViewHolder>() {

        class UserViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
            val user_iv : ImageView
            val name_tv : TextView

            init {
                user_iv = itemView.findViewById(R.id.user_iv)
                name_tv = itemView.findViewById(R.id.nama_txt)
            }
        }

        override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): UserViewHolder {
            val layoutInflater = LayoutInflater.from(parent.context)
            val view = layoutInflater.inflate(R.layout.user_list, parent, false)
            return UserViewHolder(view)
        }

        override fun getItemCount(): Int {
            Log.d("CEK_DATA", users.length().toString())
            return users.length()
        }

        override fun onBindViewHolder(holder: UserViewHolder, position: Int) {
            val item= users.getJSONObject(position)
            Log.d("CEK_DATA", item.toString())

            holder.name_tv.text = item.getString("firstName")

            GlobalScope.launch (Dispatchers.IO){
                val image = BitmapFactory.decodeStream(URL(item.getString("picture")).openStream())
                GlobalScope.launch (Dispatchers.Main){
                    holder.user_iv.setImageBitmap(image)
                }
            }
        }
    }
}