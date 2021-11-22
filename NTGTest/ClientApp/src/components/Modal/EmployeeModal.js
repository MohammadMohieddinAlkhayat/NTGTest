import React, { Component } from 'react';

export class Modal extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
       
    }
    componentDidMount() {
        this.state = {
            show: false
        };
    }
    render() {
        return (
            <div>
                <h1>Counter</h1>

            
            </div>
        );
    }
}
