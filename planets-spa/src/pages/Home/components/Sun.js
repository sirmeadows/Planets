import React from 'react';
import classes from './Sun.module.css';

const sun = (props) => {
  return (
    <>
      <div className={classes.sun}></div>
      <div className={classes.sunGlow}></div>
    </>
  );
};

export default sun;
