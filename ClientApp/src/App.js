import React, { Component } from 'react';
import './custom.css';
import FetchData from './components/FetchData';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div className='app'>
        <FetchData />
      </div>
    );
  }
}
