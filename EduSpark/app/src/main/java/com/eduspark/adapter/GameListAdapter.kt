package com.eduspark.adapter

import android.annotation.SuppressLint
import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.eduspark.R
import com.eduspark.helper.setImageByURL
import org.json.JSONArray
import org.json.JSONObject

class GameListAdapter(var ctx: Context, var items: JSONArray): RecyclerView.Adapter<GameListAdapter.ViewHolder>() {

    lateinit var listeners: Listeners

    interface Listeners {
        fun onClick(pos: Int)
    }

    fun setItemListeners(lt: Listeners) {
        listeners = lt
    }

    @SuppressLint("NotifyDataSetChanged")
    fun refreshItems(it: JSONArray) {
        items = it
        notifyDataSetChanged()
    }

    class ViewHolder(v: View, evt: Listeners): RecyclerView.ViewHolder(v) {
        val tv_title = v.findViewById<TextView>(R.id.tv_game_title)
        val tv_genre = v.findViewById<TextView>(R.id.tv_game_genre)
        val iv_gambar = v.findViewById<ImageView>(R.id.iv_game_image)

        init {
            evt.let {e ->
                tv_title.setOnClickListener {
                    e.onClick(adapterPosition)
                }
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        return ViewHolder(
            LayoutInflater
                .from(parent.context)
                .inflate(
                    R.layout.item_game,
                    parent,
                    false
                ),
            listeners
        )
    }

    override fun getItemCount(): Int {
        return items.length()
    }

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val data = items.get(position) as JSONObject

        holder.tv_title.text = data.getString("name")
        holder.tv_genre.text = data.getString("category")

        setImageByURL(
            ctx,
            "http://localhost/images/Fanta-Orange-1.jpg".replace("http://localhost", "http://103.187.147.96"),
            holder.iv_gambar
        )
    }
}