import React from "react";
import {useState} from "react";
import {Form} from "react-bootstrap";


function SearchBar(){

    const [searchText, setSearchText] = useState("");
    let searchHandler = (e) =>{
        var lowerCase = e.target.value.toLower();
        setSearchText(lowerCase);
    };
    return(

        <div className="d-flex align-items-end flex-column me-lg-5 my-5">
            <Form className="d-flex">
                <Form.Label className="flex-column ml-auto my-2 p-1" style={{fontSize:20}}>Keresés:</Form.Label>
                <Form.Control
                    type="search"
                    placeholder="Termék név"
                    className="me-2"
                    onChange={searchHandler}
                />
            </Form>
        </div>
    );
    console.log(searchText)
}

export default SearchBar;
