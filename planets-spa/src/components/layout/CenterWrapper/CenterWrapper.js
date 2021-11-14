import React, { Component } from 'react';
import classes from './CenterWrapper.module.css'

export default class CenterWrapper extends Component {
  render() {
    return (
      <div className={classes.containerStyles}>
        <div className={classes.centerStyles}>
            {this.props.children}
        </div>
      </div>
    );
  }
}


