<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::group(['prefix' => 'customers'], function(){
   Route::get('/get', [\App\Http\Controllers\CustomerController::class, 'index']);
   Route::post('/create', [\App\Http\Controllers\CustomerController::class, 'create']);
   Route::put('/update/{customer}', [\App\Http\Controllers\CustomerController::class, 'update']);
   Route::delete('/delete/{customer}', [\App\Http\Controllers\CustomerController::class, 'delete']);
});
Route::group(['prefix' => 'suppliers'], function(){
    Route::get('/get', [\App\Http\Controllers\SupplierController::class, 'index']);
    Route::post('/create', [\App\Http\Controllers\SupplierController::class, 'create']);
    Route::put('/update/{supplier}', [\App\Http\Controllers\SupplierController::class, 'update']);
    Route::delete('/delete/{supplier}', [\App\Http\Controllers\SupplierController::class, 'delete']);
});
Route::group(['prefix' => 'orders'], function(){
    Route::get('/get', [\App\Http\Controllers\OrderController::class, 'index']);
    Route::post('/create', [\App\Http\Controllers\OrderController::class, 'create']);
    Route::put('/update/{order}', [\App\Http\Controllers\OrderController::class, 'update']);
    Route::delete('/delete/{order}', [\App\Http\Controllers\OrderController::class, 'delete']);
});
Route::group(['prefix' => 'products'], function(){
    Route::get('/get', [\App\Http\Controllers\ProductController::class, 'index']);
    Route::post('/create', [\App\Http\Controllers\ProductController::class, 'create']);
    Route::put('/update/{product}', [\App\Http\Controllers\ProductController::class, 'update']);
    Route::delete('/delete/{product}', [\App\Http\Controllers\ProductController::class, 'delete']);
});
Route::group(['prefix' => 'orderitems'], function(){
    Route::get('/get', [\App\Http\Controllers\OrderItemController::class, 'index']);
    Route::post('/create', [\App\Http\Controllers\OrderItemController::class, 'create']);
    Route::put('/update/{orderitem}', [\App\Http\Controllers\OrderItemController::class, 'update']);
    Route::delete('/delete/{orderitem}', [\App\Http\Controllers\OrderItemController::class, 'delete']);
});
Route::group(['prefix' => 'permissions'], function(){
    Route::get('/get', [\App\Http\Controllers\PermissionsController::class, 'index']);
    Route::post('/create', [\App\Http\Controllers\PermissionsController::class, 'create']);
    Route::put('/update/{permission}', [\App\Http\Controllers\PermissionsController::class, 'update']);
    Route::delete('/delete/{permission}', [\App\Http\Controllers\PermissionsController::class, 'delete']);
});
Route::group(['prefix' => 'users'], function(){
    Route::get('/get', [\App\Http\Controllers\UsersController::class, 'index']);
    Route::post('/create', [\App\Http\Controllers\UsersController::class, 'create']);
    Route::put('/update/{user}', [\App\Http\Controllers\UsersController::class, 'update']);
    Route::delete('/delete/{user}', [\App\Http\Controllers\UsersController::class, 'delete']);
});
