import React, {Component} from 'react';
import styled from "styled-components";
import {ProductConsumer} from "./Context";
import {ButtonContainer} from "./Button";
import {Link} from 'react-router-dom';

class Modal extends Component {
    render() {
        return (
            <ProductConsumer>
                {(value)=>{
                    const {modalOpen, closeModal} = value;
                    const {ProductName, UnitPrice, Package, ImageSrc} = value.modalProduct;
                    if(!modalOpen){
                        return null;
                    }
                    else
                    {
                        return(
                            <ModalContainer>
                            <div className="container">
                                <div className="row">
                                   <div id="modal" className="col-8 mx-auto col-md-6 col-lg-4 text-center p-5">
                                        <h5>Hozzáadta a kosárhoz a terméket!</h5>
                                       <img src={ImageSrc} alt="product" className="img-fluid"/>
                                       <h5>{ProductName}</h5>
                                       <h5 className="text-muted">Egységár: {UnitPrice} HUF</h5>
                                       <h5 className="text-muted">Kiszerelés: {Package}</h5>
                                       <Link to='/'>
                                           <ButtonContainer onClick={()=>closeModal()}>
                                               Tovább vásárlok
                                           </ButtonContainer>
                                       </Link>
                                       <Link to='/cart'>
                                           <ButtonContainer cart onClick={()=>closeModal()}>
                                               Kosárhoz
                                           </ButtonContainer>
                                       </Link>
                                   </div>
                                </div>
                            </div>
                        </ModalContainer>
                        );
                    }
                }}
            </ProductConsumer>
        );
    }
}

export default Modal;

const ModalContainer=styled.div`
position:fixed;
top:0;
left:0;
right:0;
bottom:0;
background:rgba(0,0,0,0.3);
display:flex;
align-items:center;
justify-content:center;
#modal{
background:var(--mainWhite);
}
`;
