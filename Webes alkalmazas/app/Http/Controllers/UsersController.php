<?php

namespace App\Http\Controllers;

use App\Models\Users;
use Illuminate\Http\Request;

class UsersController extends Controller
{
    public function index()
    {
        $User = Users::with("jog")->get();

        return response()->json($User);
    }

    public function create(Request $request)
    {
        $user = new Users();

        $user->Username = $request->get("Username");
        $user->Password = $request->get("Password");
        $user->First_name = $request->get("First_name");
        $user->Last_name = $request->get("Last_name");
        $user->Email = $request->get("Email");
        $user->Birth = $request->get("Birth");
        $user->Permission = $request->get("Permission");
        $user->Deleted = $request->get("Deleted");

        $user->save();

        return response()->json(['id' => $user->id],200);
    }

    public function update(Users $user, Request $request)
    {
        $user->Username = $request->get("Username");
        $user->Password = $request->get("Password");
        $user->First_name = $request->get("First_name");
        $user->Last_name = $request->get("Last_name");
        $user->Email = $request->get("Email");
        $user->Birth = $request->get("Birth");
        $user->Permission = $request->get("Permission");
        $user->Deleted = $request->get("Deleted");

        $user->save();

        return response()->json([$user->toArray()],200);
    }

    public function delete(Users $user)
    {
        $user->delete();

        return response()->json(["OK"],204);
    }

}
