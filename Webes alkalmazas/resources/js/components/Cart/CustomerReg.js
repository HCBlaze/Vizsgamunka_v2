import React, {useState,useRef} from "react";
import axios from "axios";
import {Alert, Button, Col, Form, Row} from "react-bootstrap";
import {Link} from 'react-router-dom';

export default function CustomerReg({value}) {
    const {cartTotal} = value
    const [success, setSuccess] = useState(false);
    const [currentId, setCurrentId] = useState(0);
    const [orderId, setOrderId] = useState("");
    const lastname = useRef('');
    const firstname = useRef('');
    const phone = useRef('');
    const currentDate = new Date;
    const getRange = (size, start = 0) => Array(size).fill(0).map((_, i) => i + start);
    const getRandomDigit = () => Math.floor(Math.random() * 10);
    const generateVerificationCode = () => getRange(6).map(getRandomDigit).join('');
    const generateOrderNumber = () => {
        const today = new Date();
        const year = today.getFullYear();
        const month = today.getMonth() + 1;
        const _orderNumber = "LS-" + year + "-" + month + "-" + generateVerificationCode();
        return (
            _orderNumber
        )
    }
    const currentOderDate = () => {
        const year = currentDate.getFullYear();
        const month = currentDate.getMonth() + 1;
        const day = currentDate.getUTCDate();
        const Hour = currentDate.getHours();
        const minutes = currentDate.getMinutes();
        const second = currentDate.getSeconds();
        const date = year + "-" + month + "-" + day + " " + Hour + ":" + minutes + ":" + second;
        return (
            date
        )

    }

    const sendCustomerForm = () => {
        axios.post("/api/customers/create", {
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
    const sendOrdersForm = () => {
        axios.post("/api/orders/create", {
            OrderDate: currentOderDate(),
            OrderNumber: generateOrderNumber().toString(),
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
    console.log(value);
    return(
        <Row>
            <Col md={4}>
                <Form>
                    <Form.Group className='mb-3'>
                        <Form.Label>Vezetéknév:</Form.Label>
                        <Form.Control type="text" ref={lastname} onChange={resetSuccess}/>
                    </Form.Group>
                    <Form.Group className='mb-3'>
                        <Form.Label>Keresztnév:</Form.Label>
                        <Form.Control type="text" ref={firstname} onChange={resetSuccess}/>
                    </Form.Group>
                    <Form.Group className='mb-3'>
                        <Form.Label>Mobilszám:</Form.Label>
                        <Form.Control type="text" ref={phone} onChange={resetSuccess}/>
                    </Form.Group>

                        <Button variant="primary" onClick={()=> {sendCustomerForm()}}>Rendelés elküldése</Button>
                        {success && (
                            <Alert variant='success' className='mt-5'>
                                Rendelés leadva!
                            </Alert>
                        )}
                    <Button variant="primary" onClick={()=> {sendOrdersForm()}}>Rendelés Orders</Button>
                    <Button variant="primary" onClick={()=> {sendOrderItems()}}>Rendelés OrderItems</Button>
                </Form>
            </Col>
        </Row>
    )
}
