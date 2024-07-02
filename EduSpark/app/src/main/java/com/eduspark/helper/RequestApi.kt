package com.eduspark.helper

import android.content.Context
import android.widget.ImageView
import com.android.volley.Request
import com.android.volley.toolbox.JsonArrayRequest
import com.android.volley.toolbox.JsonObjectRequest
import com.android.volley.toolbox.Volley
import com.bumptech.glide.Glide
import com.squareup.picasso.Picasso
import org.json.JSONArray
import org.json.JSONObject

val baseURL = "http://10.0.2.2:5000"

fun setImageByURL(
    ctx: Context,
    url: String,
    iv: ImageView
) {
    Picasso.get()
        .load(url)
        .into(iv)
}

fun requestApi(
    ctx: Context,
    path: String,
    method: String,
    body: JSONObject? = null,
    onSuccess: (JSONArray) -> Unit,
    onError: (Exception) -> Unit
) {
    val reqMethod = when (method) {
        "post" -> Request.Method.POST
        "get" -> Request.Method.GET
        else -> Request.Method.GET
    }
    val token = ctx
        .getSharedPreferences("LksAppData", Context.MODE_PRIVATE)
        .getString("token", "")
    val queue = Volley.newRequestQueue(ctx)

    val req = object : JsonArrayRequest(
        reqMethod,
        baseURL + path,
        null,
        {
            onSuccess(it)
        },
        {
            onError(it)
        }
    ) {
        override fun getParams(): MutableMap<String, String> {
//            val params = HashMap<String, String>()
//            params["Authorization"] = "Bearer 115|NlBe9IqLgvPBi7bbNP5mkUowokCrUe78DB616gwf"
//            println("INI TOKEN")
//            println(token)
//            return params
            val params = HashMap<String, String>()
            params.put("Authorization", "Bearer 115|NlBe9IqLgvPBi7bbNP5mkUowokCrUe78DB616gwf")
            return params
        }
    }

    queue.add(req)
}


fun requestApiDua(
    ctx: Context,
    path: String,
    method: Int,
    body: JSONObject? = null,
    onSuccess: (JSONObject) -> Unit,
    onError: (Exception) -> Unit
) {
    val token = ctx
        .getSharedPreferences("LksAppData", Context.MODE_PRIVATE)
        .getString("token", "")
    val queue = Volley.newRequestQueue(ctx)

    val req = object : JsonObjectRequest(
        method,
        path,
        body,
        {
            onSuccess(it)
        },
        {
            onError(it)
        }
    ) {
        override fun getHeaders(): MutableMap<String, String> {
            val headers = HashMap<String, String>()
            headers.putAll(super.getHeaders())
            headers["Authorization"] = "Bearer $token"
            return headers
        }
    }
    queue.add(req)
}