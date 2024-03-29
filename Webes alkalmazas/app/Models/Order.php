<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Order extends Model
{
    use HasFactory;

    public function Customer()
    {
        return $this->belongsTo(Customer::class,'CustomerId', 'id');
    }

    public function OrderItem()
    {
        return $this->belongsTo(OrderItem::class, 'OrderId', 'id');
    }
}
