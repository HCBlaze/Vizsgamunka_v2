<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Product extends Model
{
    use HasFactory;

    public function Supplier()
    {
        return $this->belongsTo(Supplier::class, 'SupplierId', 'id');
    }

    public function  OrderItem()
    {
        return $this->belongsTo(Product::class, 'ProductId', 'id');
    }
}
