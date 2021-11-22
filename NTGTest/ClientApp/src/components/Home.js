import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

   constructor(props) {
        super(props);
        this.state = { Employees: [], loading: true };
    }

    componentDidMount() {
        this.populateEmployeesData();
    }


  render () {
    return (
      <div>
        <h1>Hello, world!</h1>
      </div>
    );
    }

    async populateEmployeesData() {
        const response = await fetch('Employee/Index');
        const data = await response.json();
        this.setState({ Employees: data, loading: false });
    }
}
