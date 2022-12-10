<?php

namespace App\Http\Controllers;


use App\Models\Supplier;
use Illuminate\Http\Request;

class SupplierController extends Controller
{
    public function index()
    {
        $supplier = Supplier::all();

        return response()->json($supplier);
    }

    public function create(Request $request)
    {
        $supplier = new Supplier();

        $supplier->CompanyName = $request->get('CompanyName');
        $supplier->ContactName = $request->get('ContactName');
        $supplier->City = $request->get('City');
        $supplier->Phone = $request->get('Phone');

        $supplier->save();

        return response()->json(['id'=>$supplier->id],200);
    }

    public function update(Supplier $supplier, Request $request)
    {
        $supplier->CompanyName = $request->get('CompanyName');
        $supplier->ContactName = $request->get('ContactName');
        $supplier->City = $request->get('City');
        $supplier->Phone = $request->get('Phone');

        $supplier->save();

        return response()->json([$supplier->toArray()],200);
    }

    public function delete(Supplier $supplier)
    {
        $supplier->delete();

        return response()->json(["OK"],204);
    }

}
