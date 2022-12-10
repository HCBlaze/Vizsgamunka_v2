<?php

namespace App\Http\Controllers;

use App\Models\Order;
use Illuminate\Http\Request;

class OrderController extends Controller
{
    public function index()
    {
        $orders = Order::with("Customer")->get();

        return response()->json($orders);
    }

    public function create(Request $request)
    {
        $order = new Order();

        $order->OrderDate = $request->get('OrderDate');
        $order->OrderNumber = $request->get('OrderNumber');
        $order->CustomerId = $request->get('CustomerId');
        $order->TotalAmount = $request->get('TotalAmount');

        $order->save();

        return response()->json(['id'=>$order->id],200);
    }

    public function update(Order $order, Request $request)
    {
        $order->OrderDate = $request->get('OrderDate');
        $order->OrderNumber = $request->get('OrderNumber');
        $order->CustomerId = $request->get('CustomerId');
        $order->TotalAmount = $request->get('TotalAmount');

        $order->save();

        return response()->json([$order->toArray()],200);
    }

    public function delete(Order $order)
    {
        $order->delete();

        return response()->json(["OK"],204);
    }

}
