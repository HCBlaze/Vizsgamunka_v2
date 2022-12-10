<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Users extends Model
{
    use HasFactory;

    public function jog()
    {
        return $this->belongsTo(Permissions::class, 'Permission', 'id');
    }
}
