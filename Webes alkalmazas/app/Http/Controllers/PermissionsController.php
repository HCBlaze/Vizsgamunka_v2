<?php

namespace App\Http\Controllers;

use App\Models\Permissions;
use Illuminate\Http\Request;

class PermissionsController extends Controller
{
    public function index()
    {
        $jogosultsagok = Permissions::with("User")->get();

        return response()->json($jogosultsagok);
    }

    public function create(Request $request)
    {
        $permission = new Permissions();

        $permission->Permission = $request->get("Permission");

        $permission->save();

        return response()->json(['id' => $permission->id],200);
    }

    public function update(Permissions $permission, Request $request)
    {
        $permission->Permission = $request->get("Permission");

        $permission->save();

        return response()->json([$permission->toArray()],200);
    }

    public function delete(Permissions $permission)
    {
        $permission->delete();

        return response()->json(["OK"],204);
    }

}
