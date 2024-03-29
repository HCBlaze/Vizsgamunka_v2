import React from "react";
import {Col, Row} from "react-bootstrap";

export default function Title({name,title}){
    return(
        <Row>
            <Col className="col-10 mx-auto my-2 text-center text-title">
                <h1 className="text-capitalize font-weight-bold">
                    {name} <strong className="text-blue">{title}</strong>
                </h1>
            </Col>
        </Row>
    );
}
