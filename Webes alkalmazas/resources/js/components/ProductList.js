import React, {Component, useState} from 'react';
import {Container, Row} from "react-bootstrap";
import Title from "./Title";
import {ProductConsumer} from "./Context";
import Product from "./Product";
import SearchBar from "./SearchBar";


class ProductList extends Component {
    render() {
        return (
            <React.Fragment>
               <SearchBar />
               <Container className="py-5">
                   <Title name="Összes" title="termék" />
                   <Row>
                        <ProductConsumer>
                            {value =>{
                                return value.allProducts.map(item=>{
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
