import React, { Component } from 'react';
import { connect } from 'react-redux';
import NoDataError from '../components/errors/NoDataError';
import LoadingScreen from '../components/loading/LoadingScreen';
import axios from 'axios';
import { apiServerUrl } from '../constants/serverDetails';
import { setPlanets } from '../redux/slices/planetsSlice';

class CheckData extends Component {

  state = {
    loading: true
  }

  componentDidMount() {
    axios.get(apiServerUrl + 'planets')
      .then(res => {
        this.props.setPlanets(res.data);
        this.setState({...this.state, loading: false});
      })
      .catch(err => {
        console.error(err);
        this.setState({...this.state, loading: false});
      })
  }

  render() {
    if (this.state.loading) {
      return <LoadingScreen />
    }
    else if (this.props.planets[0] === undefined) {
      return <NoDataError />;
    } else {
      return <>{this.props.children}</>;
    }
  }
}

const mapDispatchToProps = (dispatch) => {
  return {
    setPlanets: (planets) => dispatch(setPlanets(planets))
  }
}

const mapStateToProps = (state) => {
  return {
    planets: state.planetsStore.planets,
  };
}

export default connect(mapStateToProps, mapDispatchToProps)(CheckData);
