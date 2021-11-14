import React, { Component } from 'react';
import { connect } from 'react-redux';
import classes from './Home.module.css';
import Sun from './components/Sun';
import { Link } from 'react-router-dom';

class Home extends Component {
  render() {
    return (
      <>
        <Sun />
        <div className={classes.planetsWrapper}>
          <div className={classes.planetList}>
            {this.props.planets.map((p) => (
              <Link to={'/' + p.id} className={classes.planetLink} key={p.id}>
                <div
                  className={classes.planet}
                  style={{ backgroundImage: 'url(' + p.pictureUrl + ')' }}
                >
                  {p.name}
                </div>
              </Link>
            ))}
          </div>
        </div>
      </>
    );
  }
}

const mapStateToProps = (state) => {
  return {
    planets: state.planetsStore.planets,
  };
};

export default connect(mapStateToProps)(Home);
