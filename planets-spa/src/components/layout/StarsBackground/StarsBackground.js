import React from 'react';
import classes from './StarsBackground.module.css';

const starsBackground = (props) => {
  const twinkleStars = (idPrefix) => {
    let content = [];
    for (let i = 0; i < 20; i++) {
      const starStyle = {
        top: Math.floor(Math.random() * 100 + 1).toLocaleString() + '%',
        left: Math.floor(Math.random() * 100 + 1).toLocaleString() + '%',
      };
      content.push(
        <div
          key={idPrefix + i}
          at={i}
          className={classes.star}
          style={starStyle}
        />
      );
    }
    return content;
  };

  return (
    <div className={classes.twinkleWrapper}>
      <div className={classes.twinkle1}>{twinkleStars('first')}</div>
      <div className={classes.twinkle2}>{twinkleStars('second')}</div>
    </div>
  );
};

export default starsBackground;
