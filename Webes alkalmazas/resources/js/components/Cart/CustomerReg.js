import React, {useState,useRef} from "react";
import axios from "axios";
import {Alert, Button, Col, Form, Row} from "react-bootstrap";
import {Link} from 'react-router-dom';
import styled from "styled-components";
import {ProductConsumer} from "../Context";
import {ButtonContainer} from "../Button";
import Moment from 'moment';
import { BsXLg } from "react-icons/bs";
export default function CustomerReg({value}) {
    const {cartTotal} = value
    const [success, setSuccess] = useState(false);
    const [currentId, setCurrentId] = useState(0);
    const [orderId, setOrderId] = useState("");
    const {currentOrderNumber, setCurrentOrderNumber} = useState("");
    const [validated, setValidated] = useState(false);
    const lastname = useRef('');
    const firstname = useRef('');
    const phone = useRef('');
    const currentDate = new Date();
    const getRange = (size, start = 0) => Array(size).fill(0).map((_, i) => i + start);
    const getRandomDigit = () => Math.floor(Math.random() * 10);
    const generateVerificationCode = () => getRange(6).map(getRandomDigit).join('');
    const generateOrderNumber = () => {
        const today = new Date();
        const year = today.getFullYear();
        var month = today.getMonth() + 1;
        if (month < 10) {
            month = '0' + month;
        }
        const _orderNumber = "LS-" + year + "-" + month + "-" + generateVerificationCode();
        return (
            _orderNumber
        )

    }

    const currentOderDate = () => {
        const year = currentDate.getFullYear();
        var month = currentDate.getMonth()+ 1;
        var day = currentDate.getUTCDate();
        if (month < 10) {
            month = '0' + month;
        }
        if (day < 10) {
            day = '0' + day;
        }
        const Hour = currentDate.getHours();
        const minutes = currentDate.getMinutes();
        const second = currentDate.getSeconds();
        const date = year + "-" + month + "-" + day + " " + Hour + ":" + minutes + ":" + second;
        return (
            date
        )

    }
    const handleSubmit = (event) => {
        const form = event.currentTarget;
        if (form.checkValidity() === false) {
            event.preventDefault();
            event.stopPropagation();
        }

        setValidated(true);
    };

    const sendCustomerForm = async () => {
       await axios.post("/api/customers/create", {
            First_name: firstname.current.value,
            Last_name: lastname.current.value,
            Phone: phone.current.value,
        }).then((response) => {
            if (response.status === 200) {
                firstname.current.value = ""
                lastname.current.value = ""
                phone.current.value = ""
                setSuccess(true);
                setCurrentId(response.data.id)


            }

        })
    }
    const sendOrdersForm = async () => {
       await axios.post("/api/orders/create", {
            OrderDate: currentOderDate(),
            OrderNumber: generateOrderNumber(),
            CustomerId: currentId,
            TotalAmount: cartTotal,
            OrderStatus: "New"
        }).then((response) => {
            if (response.status === 200) {
                setOrderId(response.data.id);
            }

        })
    }
    const sendOrderItems = () => {
        value.cart.map((item) => {
            const currentProductId = item.id;
            const currentProductUnitPrice = item.UnitPrice;
            const quantity = 1;

            axios.post("/api/orderitems/create", {
                OrderId: orderId,
                ProductId: currentProductId,
                UnitPrice: currentProductUnitPrice,
                Quantity: quantity,
            })
            axios.put("/api/products/update/"+currentProductId, {
                ProductName:item.ProductName,
                SupplierId:item.SupplierId,
                UnitPrice: item.UnitPrice,
                Package: item.Package,
                Stock: item.Stock - quantity,
                ImageSrc: item.ImageSrc
            })
        })
    }
    const resetSuccess = () => {
        if (success) {
            setSuccess(false);
        }
    }
    return(
        <ProductConsumer>
            {(value) =>{
                const{customerRegOpen, closeCustomerReg} = value;
                if (!customerRegOpen){
                    return null;
                }
                else{
                    return (
                        <ModalContainer>
                            <Form id="modal" noValidate validated={validated} onSubmit={handleSubmit}>
                                <BsXLg className="btn-close" onClick={closeCustomerReg}/>
                                    <div id="modal" className="col-10 mx-auto text-center p-5">
                                        <h3>Vásárló adatai:</h3>
                                        <Form.Group className='mb-3' controlId="validateLastName">
                                            <Form.Label>Vezetéknév:</Form.Label>
                                            <Form.Control type="text" placeholder="Vezetéknév" ref={lastname} onChange={resetSuccess} required/>
                                            <Form.Control.Feedback type="invalid">A mező kitöltése kötelező</Form.Control.Feedback>
                                        </Form.Group>
                                        <Form.Group className='mb-3' controlId="validateFirstName">
                                            <Form.Label>Keresztnév:</Form.Label>
                                            <Form.Control type="text" placeholder="Keresztnév" ref={firstname} onChange={resetSuccess} required/>
                                            <Form.Control.Feedback type="invalid">A mező kitöltése kötelező</Form.Control.Feedback>
                                        </Form.Group>
                                        <Form.Control.Feedback>Rendben!</Form.Control.Feedback>
                                        <Form.Group className='mb-3' controlId="validatePhone">
                                            <Form.Label>Mobilszám:</Form.Label>
                                            <Form.Control type="text" placeholder="+36 xx xxx xxxx" ref={phone} onChange={resetSuccess} required/>
                                            <Form.Control.Feedback type="invalid">A mező kitöltése kötelező</Form.Control.Feedback>
                                        </Form.Group>
                                        <Form.Group className='mb-3'>
                                            <Form.Check required label="A rendelés leadása fizetési köteletettséggel jár!" feedback="El kell fogadni a feltételeket!" feedbackType="invalid" onClick={sendCustomerForm}/>
                                        </Form.Group>
                                        <Form.Group className='mb-3'>
                                            <Form.Check required label="Elfogadom a vásárlói feltételeket!" feedback="El kell fogadni a feltételeket!" feedbackType="invalid" onClick={sendOrdersForm}/>
                                        </Form.Group>
                                        <Link to='/'>
                                            <ButtonContainer onClick={()=>closeCustomerReg()}>
                                                Tovább vásárolok
                                            </ButtonContainer>
                                        </Link>
                                        <ButtonContainer type="submit" cart onClick={sendOrderItems}>
                                            Rendelés véglegesítése
                                        </ButtonContainer>
                                    </div>
                            </Form>
                        </ModalContainer>
                    );
                }
            }}
        </ProductConsumer>
    )
}

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
.btn-close{
display:flex;
cursor:pointer;
position: absolute;
padding:0.8rem 0.8rem 0.8rem 0.8rem;
}
`;
