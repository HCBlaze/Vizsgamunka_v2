import React, {Component, useState} from 'react';
import {Container, Form, Row} from "react-bootstrap";
import Title from "./Title";
import {ProductConsumer} from "./Context";
import Product from "./Product";

class ProductList extends Component {
    state={
        searchText: "",
    }
    searchHandler(e){
        this.setState({searchText: e.target.value.substr(0,20)});
    }

    render() {
        return (
            <React.Fragment>
               <Container className="py-5">
                   <div className="d-flex align-items-end flex-column me-lg-5 my-5">
                       <Form className="d-flex">
                           <Form.Label className="flex-column ml-auto my-2 p-1 text-capitalize text-title">Keresés:</Form.Label>
                           <Form.Control
                               type="search"
                               placeholder="Termék név"
                               className="me-2"
                               value={this.state.searchText}
                               onChange={this.searchHandler.bind(this)}

                           />
                       </Form>
                   </div>
                   <Title name="Összes" title="termék" />
                   <Row>
                        <ProductConsumer>
                            {value =>{
                                let filterProducts = value.allProducts.filter((filterProducts) =>{
                                    return filterProducts.ProductName.toLowerCase().indexOf(this.state.searchText) !== -1
                                });
                                return filterProducts.map(item=>{
                                    return <Product key={item.id} item={item}/>;
                                });
                            }}
                        </ProductConsumer>
                   </Row>
               </Container>
            </React.Fragment>
        );
    }
}

export default ProductList;
