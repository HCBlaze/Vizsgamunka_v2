import React, {Component} from 'react';
import axios from "axios";

const ProductContext = React.createContext();

class ProductProvider extends Component {
    state={
        allProducts: [],
        detailsProduct: [],
        cart: [],
        modalOpen:false,
        modalProduct: [],
        cartTotal:0,
    };
    componentDidMount(){
        this.setProducts();
    }
    setProducts = async ()=>{
        let tempProducts = [];
        const response = await axios.get("/api/products/get");
        if(response.status === 200){
            response.data.forEach(item =>{
                const singleItem = {...item};
                tempProducts = [...tempProducts,singleItem];
            });
            this.setState(()=>{
                return {allProducts: tempProducts};
            });
        }
    };

    getItem = (id) =>{
        const product = this.state.allProducts.find(item=> item.id ===id)
        return product;
    };

    handleDetails = (id) =>{
       const product = this.getItem(id);
       this.setState(()=>{
           return {detailsProduct: product}
       });
    };
    addToCart = (id) =>{
        let tempProducts = [...this.state.allProducts];
        const index = tempProducts.indexOf(this.getItem(id));
        const product = tempProducts[index];
        this.setState(()=>{
            return {allProducts: tempProducts,cart:[...this.state.cart,product]};
        }, ()=>{this.addTotals()});
    };
    openModal= (id) =>{
        const product = this.getItem(id);
        this.setState(()=>{
            return {modalProduct:product, modalOpen:true}
        });
    };
    closeModal= () =>{
        this.setState(()=>{
            return{modalOpen:false}
        });
    };
    increment = (id,setCounter,counter) =>{
        let tempCart = [...this.state.cart];
        const selectedProduct = tempCart.find(item=>item.id === id);
        const index = tempCart.indexOf(selectedProduct);
        const product = tempCart[index];
        return(
            setCounter(counter + 1)
    )

        this.setState(()=>{return {cart:[...tempCart]}},()=>{this.addTotals()});

    };
    decrement = (id, setCounter,counter) =>{
        let tempCart = [...this.state.cart];
        const selectedProduct = tempCart.find(item=>item.id === id);
        const index = tempCart.indexOf(selectedProduct);
        const product = tempCart[index];
        return(
            setCounter(counter - 1)
        )

        this.setState(()=>{return {cart:[...tempCart]}},()=>{this.addTotals()});
    };
    removeItem = (id) =>{
        let tempProducts = [...this.state.allProducts];
        let tempCart = [...this.state.cart];
        tempCart = tempCart.filter(item =>item.id !== id);
        const index = tempProducts.indexOf(this.getItem(id));
        let removedProduct = tempProducts[index];

        this.setState(()=>{
            return{
                cart:[...tempCart],
                allProducts:[...tempProducts]
            }
        }, ()=>this.addTotals());

    };
    clearCart = () =>{
        this.setState(()=>{
            return {cart:[]}
        },()=>{
            this.setProducts();
            this.addTotals();
        });
    };
    addTotals = () =>{
        let total = 0;
        this.state.cart.map(item => (total += parseInt(item.UnitPrice)))
        this.setState(()=>{
            return{
                cartTotal:total
            }
        });
    }
render() {
        return (
            <ProductContext.Provider value={{
                ...this.state,
                handleDetails:this.handleDetails,
                addToCart:this.addToCart,
                openModal:this.openModal,
                closeModal: this.closeModal,
                increment:this.increment,
                decrement:this.decrement,
                removeItem:this.removeItem,
                clearCart:this.clearCart,
            }}>
                {this.props.children}
            </ProductContext.Provider>
        );
    }
}

const ProductConsumer = ProductContext.Consumer;

export {ProductProvider, ProductConsumer};
