import React, { Component, useState, useEffect} from 'react';
import { Button, Modal, ModalHeader, ModalBody, ModalFooter,Input, Dropdown, DropdownToggle, DropdownMenu, DropdownItem } from "reactstrap";




export function Home() {
    // Declare a new state variable, which we'll call "count"
    const [employees, setEmployees] = useState([]);
    const [loading, setLoading] = useState(false);
    const [isOpen, setIsOpen] = useState(false);
    const [isDropDownOpen, setIsDropDownOpen] = useState(false);

  
          useEffect(() => {
              populateEmployeesData()
          });

    const populateEmployeesData = async () => {
        const response = await fetch('Employee/Index');
        const data = await response.json();
        setEmployees(data);
        setLoading(false);
    }


    return (
        <div>
            <div>
                <Button className="mb-3 mt-3" color="danger" onClick={() => setIsOpen(true)}> AssignJob</Button>
                <Modal isOpen={isOpen} toggle={() => setIsOpen(prev => !prev)}>
                    <ModalHeader toggle={() => setIsOpen(false)}>
                        Assign Job
                    </ModalHeader>
                    <ModalBody>
                        <Dropdown className="mb-3" isOpen={isDropDownOpen} toggle={() => setIsDropDownOpen((prev) => !prev)}>
                            <DropdownToggle caret >
                                Employee Name
                            </DropdownToggle>
                            <DropdownMenu>
                                {employees.map(employee => (<DropdownItem key={employee.id} >
                                    {employee.fullName}
                                </DropdownItem>))}
                            </DropdownMenu>
                        </Dropdown>
                        <Input/>
                    </ModalBody>
                    <ModalFooter>
                        <Button color="primary" onClick={function noRefCheck() { }}> submit</Button>
                        {' '}
                        <Button onClick={() => setIsOpen(false)}>Cancel</Button>
                    </ModalFooter>
                </Modal>
            </div>

            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Full Name</th>
                        <th>Phone Number</th>

                    </tr>
                </thead>
                <tbody>
                    {employees.map(employee =>
                        <tr key={employee.id}>
                            <td >{employee.id}</td>
                            <td >{employee.fullName}</td>
                            <td >{employee.phoneNumber}</td>
                        </tr>
                    )}
                </tbody>
            </table>

        </div>
    );
}




