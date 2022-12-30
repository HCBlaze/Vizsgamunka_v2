import React from "react";
import {Link} from 'react-router-dom';


export default function CartTotals({value}){
    console.log({value})
    const {cartTotal,clearCart} = value;
    return(
        <React.Fragment>
            <div className="container">
                <div className="row">
                    <div className="col-12 mt-2 ml-sm-5 ml-md-auto col-sm-12 text-capitalize text-end">
                        <Link to="/">
                            <button className="btn btn-outline-danger text-uppercase mb-3 px-5" type="button" onClick={()=>clearCart()}>Kosár ürítése</button>
                        </Link>
                        <h5>
                            <span className="text-title">Fizetendő:
                                <strong> {cartTotal} HUF</strong>
                            </span>
                        </h5>
                    </div>
                </div>
            </div>
        </React.Fragment>
    )
}
