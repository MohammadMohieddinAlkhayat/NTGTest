import React, { Component } from 'react';
import { EmployeeModal } from './EmployeeModal';
export class Home extends Component {
  static displayName = Home.name;

   constructor(props) {
        super(props);
        this.state = { employees: [], loading: true };
    }

    componentDidMount() {
        this.populateEmployeesData();
    }
    handleClick = () => {
        EmployeeModal.setState({
            show: true
        });
    }


    static renderEmployeesTable(employees) {
        return (
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
        );
    }
  render () {
      let contents = this.state.loading
          ? <p><em>Loading...</em></p>
          : Home.renderEmployeesTable(this.state.employees);
      return (
          <div>
              <button onClick={this.handleClick}>
                  Assign Job
              </button>
              <h1 id="tabelLabel" >Employees</h1>
              {contents}
          </div>
      );
    }



    async populateEmployeesData() {
        const response = await fetch('Employee/Index');
        const data = await response.json();
        console.log(data);
        this.setState({ employees: data, loading: false });
    }




}
