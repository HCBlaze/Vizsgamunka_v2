import React, {Component} from 'react';
import {ProductConsumer} from "./Context";
import {Link} from 'react-router-dom';
import {ButtonContainer} from "./Button";

class Details extends Component {
    render() {
        return (
            <ProductConsumer>
                {(value)=>{
                    const {id, ProductName,  UnitPrice, Package, Stock, ImageSrc} = value.detailsProduct
                    const{ CompanyName,ContactName, City, Phone} = value.detailsProduct.supplier
                    const {inCart} = value;
                    return(
                        <div className="container py-5">
                            <div className="row">
                                <div className="col-10 mx-auto text-center text-slanted text-blue my-5">
                                    <h1>{ProductName}</h1>
                                </div>
                            </div>
                            <div className="row">
                                <div className="col-10 mx-auto col-md-6 my-3">
                                    <img src={ImageSrc} alt="Termék" className="img-fluid"/>
                                </div>
                                <div className="col-10 mx-auto col-md-6 my-3 text-capitalize">
                                    <h3>Termék megnevezése: {ProductName}</h3>
                                    <h4 className="text-title text-uppercase text-muted mt-3 mb-2 ">
                                        Beszállító: <span className="text-uppercase">{CompanyName}</span>
                                    </h4>
                                    <h4 className="text-title text-uppercase text-muted mt-3 mb-2 ">
                                        Kapcsolattartó: <span className="text-uppercase">{ContactName}</span><br/>
                                        <br/>
                                        Mobilszám:<span className="text-uppercase">{Phone}</span>
                                    </h4>
                                    <h4 className="text-title text-uppercase text-muted mt-3 mb-2 ">
                                        Város: <span className="text-uppercase">{City}</span>
                                    </h4>
                                    <h4 className="text-blue">
                                        <strong>
                                            Ár: {UnitPrice}<span> HUF</span>
                                        </strong>
                                    </h4>
                                    <p className="font-weight-bold mt-3 mb-0">
                                        Termék információk:<br/>
                                        Kiszerelés: {Package}<br/>
                                        Raktárkészlet: {Stock} db
                                    </p>
                                    <div>
                                        <Link to="/">
                                            <ButtonContainer>
                                                Termékekhez
                                            </ButtonContainer>
                                        </Link>
                                        <ButtonContainer
                                            cart
                                            onClick={()=>{
                                            value.addToCart(id);
                                            value.openModal(id);
                                        }}>
                                            Kosárba
                                        </ButtonContainer>
                                    </div>
                                </div>
                            </div>
                        </div>
                    )
                }}
            </ProductConsumer>
        );
    }
}

export default Details;
