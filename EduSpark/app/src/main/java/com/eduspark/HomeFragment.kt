package com.eduspark

import android.annotation.SuppressLint
import android.content.Context
import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.LinearLayoutManager
import com.android.volley.Request
import com.eduspark.adapter.GameListAdapter
import com.eduspark.databinding.FragmentHomeBinding
import com.eduspark.helper.requestApi
import com.eduspark.helper.requestApiDua
import org.json.JSONArray
import org.json.JSONObject

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [HomeFragment.newInstance] factory method to
 * create an instance of this fragment.
 */
class HomeFragment : Fragment() {
    // TODO: Rename and change types of parameters
    private var param1: String? = null
    private var param2: String? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        arguments?.let {
            param1 = it.getString(ARG_PARAM1)
            param2 = it.getString(ARG_PARAM2)
        }
    }

    lateinit var gameListAdapter: GameListAdapter
    var gameList: JSONArray = JSONArray()

    @SuppressLint("NotifyDataSetChanged")
    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?,
    ): View? {
        val binding = FragmentHomeBinding.inflate(inflater, container, false)

        gameListAdapter = GameListAdapter(requireContext(), gameList)
        binding.rvGames.adapter = gameListAdapter
        binding.rvGames.layoutManager = LinearLayoutManager(requireContext())

        binding.tvLagi.setOnClickListener {
            requestApiDua(
                ctx = requireContext(),
                path = "http://103.187.147.96/api/product/1",
                method = Request.Method.GET,
                onSuccess = {
                    println("OKE LE 2")
                    println(it)
                },
                onError = {
                    println("YAH LE 2")
                    println(it)
                }
            )
        }

        binding.tvSubtitle.setOnClickListener {
            requireContext()
                .getSharedPreferences("LksAppData", Context.MODE_PRIVATE)
                .edit()
                .remove("token")
                .apply()
        }

        gameListAdapter.setItemListeners(object : GameListAdapter.Listeners{
            override fun onClick(pos: Int) {
                val tesbo = JSONObject()
                tesbo.put("username", "tezt")
                tesbo.put("password", "tezt")

                requestApiDua(
                    ctx = requireContext(),
                    path = "http://103.187.147.96/api/login",
                    method = Request.Method.POST,
                    body = tesbo,
                    onSuccess = {
                        if (it.getInt("status") == 200) {
                            println("OKE LE")
                            requireContext()
                                .getSharedPreferences("LksAppData", Context.MODE_PRIVATE)
                                .edit()
                                .putString("token", it.getString("data"))
                                .apply()
                        }
                    },
                    onError = {
                        println("YAH LE")
                        println(it)
                    }
                )
            }
        })

        requestApi(
            ctx = requireContext(),
            path = "/api/games",
            method = "get",
            onSuccess = {
                gameList = it
                gameListAdapter.refreshItems(it)
            },
            onError = {
                println(it)
            }
        )

        return binding.root
    }

    companion object {
        /**
         * Use this factory method to create a new instance of
         * this fragment using the provided parameters.
         *
         * @param param1 Parameter 1.
         * @param param2 Parameter 2.
         * @return A new instance of fragment HomeFragment.
         */
        // TODO: Rename and change types and number of parameters
        @JvmStatic
        fun newInstance(param1: String, param2: String) =
            HomeFragment().apply {
                arguments = Bundle().apply {
                    putString(ARG_PARAM1, param1)
                    putString(ARG_PARAM2, param2)
                }
            }
    }
}