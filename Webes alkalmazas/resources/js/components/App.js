import React, {Component} from 'react';
import {Routes, Route} from 'react-router-dom';
import Navbar from "./Navbar";
import ProductList from "./ProductList";
import Details from "./Details";
import Cart from "./Cart/Cart";
import Default from "./Default";
import Modal from "./Modal";
import 'bootstrap/dist/css/bootstrap.min.css';

class App extends Component {
    render() {
        return (
             <React.Fragment>
                 <Navbar />
                 <Routes>
                     <Route exact path="/" element={<ProductList />} />
                     <Route path="/details" element={<Details />} />
                     <Route path="/cart" element={<Cart />} />
                     <Route element={<Default />} />
                 </Routes>
                 <Modal/>
             </React.Fragment>
        );
    }
}

export default App;
