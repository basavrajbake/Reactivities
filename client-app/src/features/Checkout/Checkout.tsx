import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useState, Component } from "react";
import { Button, Container, Form, Segment, Table, TableBody, TableHeader, TableRow } from "semantic-ui-react";
import ServiceForm from "./../Services/Services"


export default observer(function Checkout(){

    
        const CustomerCheckout = [
          ["CustID", "GuestName", "ServiceUsed", "Price"],
          ["Cus001", "Basav", "Spa", "1500"],
          ["Cus001", "Basav", "Restaurant", "3000"],
          ["Cus001", "Basav", "Gym", "800"]
        ];

    return (
        <Segment clearing>
            <Form>
                <Table>
                        <TableHeader>
                        {CustomerCheckout[0].map((item, index) => {
                 return <th><br></br>{item}<br></br></th>;
            })}
                    </TableHeader>
    <TableBody>
    {CustomerCheckout.slice(1, CustomerCheckout.length).map((item, index) => {
            return (
              <tr>
                <td>{item[0]}</td>               
                <td>{item[1]}</td>
                <td>{item[2]}</td>
                <td>{item[3]}</td>
              </tr>
            );
          })}
        </TableBody>                
        </Table>
           
        <Container>
           <h2>TotalBill</h2> 
            <Form.Input id="Customer"  value="4300"/>
        </Container>
        <br></br>
        <Container>
        <Button id='Submit' floated='left' positive type='submit' content='Checkout' />
        </Container>
        </Form>
            
                    
        </Segment>
              
    )
})