import React, { Component } from 'react';
import CenterWrapper from '../layout/CenterWrapper/CenterWrapper';

export default class LoadingScreen extends Component {
  render() {
    return (
      <CenterWrapper>
        <div className='dot-revolution'></div>
      </CenterWrapper>
    );
  }
}
