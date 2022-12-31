import React, {Component} from 'react';
import Title from "../Title";
import Columns from "./Columns";
import EmptyCart from "./EmptyCart";
import {ProductConsumer} from "../Context";
import CartList from "./CartList";
import CartTotals from './CartTotals';
import CustomerReg from "./CustomerReg";
class Cart extends Component {
    render() {
        return (
            <section>
                <ProductConsumer>
                    {value =>{
                       const {cart} = value;
                       if(cart.length>0){
                           return(
                               <React.Fragment>
                                   <Title name="te" title="kosarad"/>
                                   <Columns />
                                   <CartList value={value} />
                                   <CartTotals value={value} />
                                   <CustomerReg value={value} />
                               </React.Fragment>
                            );
                       }
                       else{
                           return(
                               <EmptyCart />
                           )
                       }
                    }}
                </ProductConsumer>
            </section>
        );
    }
}

export default Cart;
