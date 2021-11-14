import React, { Component } from 'react';
import CenterWrapper from '../layout/CenterWrapper/CenterWrapper';

export default class NoDataError extends Component {
  render() {
    return (
      <CenterWrapper>
        <div>There is no data to display, please check your connection</div>{' '}
      </CenterWrapper>
    );
  }
}
