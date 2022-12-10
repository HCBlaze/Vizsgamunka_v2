<?php

namespace App\Http\Controllers;

use App\Models\Customer;
use Illuminate\Http\Request;

class CustomerController extends Controller
{
    public function index()
    {
        $customer = Customer::all();

        return response()->json([$customer],200);
    }

    public function create(Request $request)
    {
        $customer = new Customer();

        $customer->First_name = $request->get('First_name');
        $customer->Last_name = $request->get('Last_name');
        $customer->Phone = $request->get('Phone');

        $customer->save();

        return response()->json(['id' => $customer->id],200);
    }

    public function update(Customer $customer, Request $request)
    {
        $customer->First_name = $request->get('First_name');
        $customer->Last_name = $request->get('Last_name');
        $customer->Phone = $request->get('Phone');

        $customer->save();

        return response()->json([$customer->toArray()],200);
    }

    public function delete( Customer $customer)
    {
        $customer->delete();

        return response()->json(["OK"],204);
    }

}
