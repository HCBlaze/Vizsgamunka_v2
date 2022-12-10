<?php

namespace App\Http\Controllers;

use App\Models\OrderItem;
use Illuminate\Http\Request;

class OrderItemController extends Controller
{
    public function index()
    {
        $orderitem = OrderItem::with(["Order","Product", "Order.Customer", "Product.Supplier"])->get();

        return response()->json($orderitem);
    }

    public function create(Request $request)
    {
        $orderitem = new OrderItem();

        $orderitem->OrderId = $request->get('OrderId');
        $orderitem->ProductId = $request->get('ProductId');
        $orderitem->UnitPrice = $request->get('UnitPrice');
        $orderitem->Quantity = $request->get('Quantity');

        $orderitem->save();

        return response()->json(['id'=>$orderitem->id],200);
    }

    public function update(OrderItem $orderitem, Request $request)
    {
        $orderitem->OrderId = $request->get('OrderId');
        $orderitem->ProductId = $request->get('ProductId');
        $orderitem->UnitPrice = $request->get('UnitPrice');
        $orderitem->Quantity = $request->get('Quantity');

        $orderitem->save();

        return response()->json([$orderitem->toArray()],200);
    }

    public function delete(OrderItem $orderitem)
    {
        $orderitem->delete();

        return response()->json(["OK"],204);
    }

}
