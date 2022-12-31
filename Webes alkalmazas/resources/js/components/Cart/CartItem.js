import React, {useState} from "react";
import {BsTrash} from 'react-icons/bs';

export default function CartItem(item){

    const{id,ProductName,Package,UnitPrice,ImageSrc} = item.item;
    const{increment,decrement,removeItem, cartTotal} = item.value;
    const [counter, setCounter] = useState(1);
    const itemTotal = UnitPrice * counter;
    if (counter === 0)
    {
        {removeItem(id)}
    }
    return(
        <div className="row my-2 text-capitalize text-center">
            <div className="col-10 mx-auto col-lg-2">
                <span className="d-lg-none">Termékneve:</span><br/>
                <img src={ImageSrc} style={{width: '5rem',height:"5rem"}} className="img-fluid" alt="termekkep"/>
                <h5 className="text-title">{ProductName}</h5>
            </div>
            <div className="col-10 mx-auto col-lg-2">
                <span className="d-lg-none">Kiszerelés:</span>
                <h5 className="text-title">{Package}</h5>
            </div>
            <div className="col-10 mx-auto col-lg-2">
                <span className="d-lg-none">Egységár(HUF):</span>
                <h5 className="text-title">{UnitPrice}</h5>
            </div>
            <div className="col-10 mx-auto col-lg-2 my-2 my-lg-0">
                <div className="d-flex justify-content-center">
                    <div>
                        <span className="btn btn-black mx-1" onClick={()=>{decrement(id,setCounter,counter)}}>-</span>
                        <span className="btn btn-black mx-1">{counter}</span>
                        <span className="btn btn-black mx-1" onClick={()=>{increment(id,setCounter,counter)}}>+</span>
                    </div>
                </div>
            </div>
            <div className="col-10 mx-auto col-lg-2">
                <div className="cart-icon d-flex justify-content-center" onClick={()=>removeItem(id)}>
                    <BsTrash />
                </div>
            </div>
            <div className="col-10 mx-auto col-lg-2">
                <strong>
                    Termék végösszeg: {itemTotal} HUF
                </strong>
            </div>
        </div>
    )
}
