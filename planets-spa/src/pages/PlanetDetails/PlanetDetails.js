import { useParams } from 'react-router-dom';
import { useSelector } from 'react-redux';
import classes from './PlanetDetails.module.css';
import { Link } from 'react-router-dom';

export default function PlanetDetails() {
  const { id } = useParams();
  const planet = useSelector((store) =>
    store.planetsStore.planets.find((p) => p.id === +id)
  );

  return (
    <>
    <Link to="/" className={classes.back}>Back to Solar System</Link>
      <div className={classes.detailsWrapper}>
        <div className={classes.detailsLayout}>
          <img
            src={planet.pictureUrl}
            alt={planet.name}
            className={classes.planetImage}
          />
          <div className={classes.planetDescriptionPanel}>
            <p><span>Name:</span> {planet.name}</p>
            <p><span>Namesake:</span> {planet.namesake}</p>
            <p><span>Distance from Sun:</span> {planet.milesFromSun} miles</p>
            <p><span>Diameter:</span> {planet.diameterMiles} miles</p>
            <p><span>Mass:</span> {planet.massKilograms} x 10^24 kg</p>
            <p><span>Length of Year:</span> {planet.lengthOfYearInDays} Earth Days</p>
          </div>
        </div>
      </div>
    </>
  );
}
