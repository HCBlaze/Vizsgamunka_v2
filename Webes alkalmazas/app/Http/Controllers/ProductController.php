<?php

namespace App\Http\Controllers;

use App\Models\Product;
use Illuminate\Http\Request;

class ProductController extends Controller
{
    public function index()
    {
        $product = Product::with("Supplier")->get();

        return response()->json($product);
    }

    public function create(Request $request)
    {
        $product = new Product();

        $product->ProductName = $request->get('ProductName');
        $product->SupplierId = $request->get('SupplierId');
        $product->UnitPrice = $request->get('UnitPrice');
        $product->Package = $request->get('Package');
        $product->Stock = $request->get('Stock');

        $product->save();

        return response()->json(['id'=>$product->id],200);
    }

    public function update(Product $product, Request $request)
    {
        $product->ProductName = $request->get('ProductName');
        $product->SupplierId = $request->get('SupplierId');
        $product->UnitPrice = $request->get('UnitPrice');
        $product->Package = $request->get('Package');
        $product->Stock = $request->get('Stock');

        $product->save();

        return response()->json([$product->toArray()],200);
    }

    public function delete(Product $product)
    {
        $product->delete();

        return response()->json(["OK"],204);
    }

}
