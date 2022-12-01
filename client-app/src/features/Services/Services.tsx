import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useState } from "react";
import { Button, Container, Form, Segment } from "semantic-ui-react";
import Select, { DropdownIndicatorProps } from 'react-select'




  interface ServiceOption {
    readonly value: string;
    readonly label: string;
    readonly color: string;
    readonly isFixed?: boolean;
    readonly isDisabled?: boolean;
  }

  
  
 const serviceOptions = [
    { value: 'S_Facial', label: 'S_Facial', color: '#00B8D9' },
    { value: 'S_HairSpa', label: 'S_HairSpa', color: '#0052CC'},
    { value: 'GYM', label: 'GYM', color: '#5243AA' },
    { value: 'R_Breakfast', label: 'R_Breakfast', color: '#5243AA' },
    { value: 'R_Lunch', label: 'R_Lunch', color: '#5243AA' },
    { value: 'R_Dinner', label: 'R_Dinner', color: '#5243AA' },
    { value: 'Bar', label: 'Bar', color: '#5243AA'}
  ];

 
  let selectedValue:string;
  export default () => {
    const [isClearable, setIsClearable] = useState(true);
    const [isSearchable, setIsSearchable] = useState(true);
    const [isDisabled, setIsDisabled] = useState(false);
    const [isLoading, setIsLoading] = useState(false);
    const [isRtl, setIsRtl] = useState(false);

    const [selectedValue, Setvalue] = useState("0");

   function handleInputChange(event: { preventDefault: () => void; target: { value: any; }; }){
    //selectedValue=event.target.value;
    Setvalue(event.target.value);
    console.log(selectedValue);
   }


    
    return (
        <Segment clearing>
 <Form autoComplete='off'    >
            <Container>
           <h3>Customer Name</h3> 
            <Form.Input id="Customer"  value="Basav"/>
        </Container>
            <h3>Services</h3>
        <select id="ddlFruits" onChange={handleInputChange}>
    <option value="">Select</option>
    <option value="1500">S_Facial</option>
    <option value="2500">S_HairSpa</option>
    <option value="800">GYM</option>
    <option value="1200">R_Breakfast</option>
    <option value="2000">R_Lunch</option>
    <option value="1800">R_Dinner</option>
    <option value="1000">Bar</option>
    
      </select>
        
        
           <h2>Price</h2> 
            <Form.Input id="Price"  value={selectedValue}/>
        
        <Button id='Submit' floated='right' positive type='submit' content='Submit' />
       </Form>
       
        </Segment>
       
    );
  };
